/***
* Name: Water flow in a river graph, using water flow in rivers
* Author: Benoit Gaudou and Patrick Taillandier
* Description: In this model, the flow of water is modeled through the exchange of water between elements of rivers.
* 	The only water input comes (every 20 steps) from the source points. Then the water flows toward the outlet point.
* Tags: shapefile, gis, graph, gui, hydrology, water flow
***/

model Waterflowrivergraph

global {
	file river_shape_file <- shape_file("../includes/river_simple1.shp");
	file poi_file <- shape_file("../includes/river_poi.shp");
	file tram_mua_shapefile <- file("../includes/TramMua.shp");

	geometry shape <- envelope(river_shape_file) +0.05;
	Station source;
	Station dest;
	graph the_river;


	init {
		create river from: river_shape_file;
		create poi from: poi_file;
		ask river{
			neighbor_river<-river where (each intersects self);
		}
		create Station from: tram_mua_shapefile ;
		source <- first(Station where (each.Name = "Song Hong"));
		dest <- first(Station where (each.Name = "Song Thai Binh")); 
		the_river <- as_edge_graph(river); 
	}
	
	reflex water_flow { 
		 if (every(10#cycles)) {
			ask source  {
				do give_water;
			}	
			ask dest{
				do take_water;
			}
		 } else {		
			ask river {
				do water_flow;
			}
			ask river {
				do update_water_level;
			}			
		}
	}
}

species poi {
	string type;
	river closest_river ;
	
//	action give_water {
//		closest_river.water_volume <- 200.0;
//	}
	
	aspect default {
		draw circle(0.005) color: (type="source") ? #green : #red border: #black;		
	}	
}
species Station skills: [moving] {
	rgb color <- rnd_color(255);
	list<float> heso <- [];
	float hh <- 0.0;
	float rad <- 0.01;
	string Name;
	int ll <- 0;
	geometry shape <- rectangle(0.005, 0.0025);
	float perception_distance <- rad;
	geometry TL_area;
	geometry HL_area;
	float TL_level <- 0.0;
	float HL_level <- 0.0;
	list<int> pa;

	action give_water {
//		write "give water";
		ask river overlapping self{water_volume <-water_volume+ 0.004;}
	}

	action take_water {
		ask river overlapping self{water_volume <-water_volume -0.004;}
	}

	aspect default {
		draw shape color: #red;
		draw circle(rad) color: #red empty: true;
		draw Name + " " + " " + TL_level + " " + HL_level size: 10 at: location + 0.002 color: #red; // heso[cycle mod 4388] + 
		if (TL_area != nil) {
			draw TL_area color: #green;
		}

		if (HL_area != nil) {
			draw HL_area color: #green;
		}

	}

}


species river {
	list<river> neighbor_river ;
	float water_volume;
	float water_volume_from_other;
	
	action water_flow {
		float avg<-water_volume / length(neighbor_river);
		ask	neighbor_river - self{			
			water_volume_from_other <- water_volume_from_other + avg;
		}
	}
	
	action update_water_level {
		float avg<-water_volume / length(neighbor_river);
		water_volume <- avg + water_volume_from_other;
		water_volume<-water_volume>0.008?0.008:water_volume;
		water_volume_from_other <- 0.0;
	}
	
	aspect default {
		draw shape color: #blue;	
		draw shape + water_volume color: #blue;
		
			
	}
}

experiment flow type: gui {
	output {
	 	display "Water Unit" { 
			species river ; 
//			species poi;
			species Station;			
		}
	}
}
