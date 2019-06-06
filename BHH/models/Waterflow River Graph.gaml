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

	geometry shape <- envelope(river_shape_file) ;
	Station source;
	Station dest;
	graph the_river;
//	poi outlet;

	init {
		create river from: river_shape_file;
		create poi from: poi_file;
		create Station from: tram_mua_shapefile ;
		source <- first(Station where (each.Name = "Song Hong"));
		dest <- first(Station where (each.Name = "Song Thai Binh"));
//		ask poi{
//			ask poi where (each.location=location){
//				do die;21
//			}
//		}
//		outlet <- any(poi);//poi first_with(each.type = "outlet");
		the_river <- as_edge_graph(river);
		ask poi {
			closest_river <- river where (each touches self);
			path path_to_outlet <- path_between(the_river,self,source);				
				loop i from: 0 to: length(path_to_outlet.edges) - 2 {
					river(path_to_outlet.edges[i]).neighbor_river <+ river(path_to_outlet.edges[i+1]);
				}

//			path_to_outlet <- path_between(the_river,self,dest);
//				
//				loop i from: 0 to: length(path_to_outlet.edges) - 2 {
//					river(path_to_outlet.edges[i]).neighbor_river <+ river(path_to_outlet.edges[i+1]);
//				}
		} 
	}
	
	reflex water_flow {
		// Every 20 simulation steps, the source points provide water to the closest river.
		if (every(3#cycles)) {
			ask poi  {
				do give_water;
			}	
		//  For a visualisation purpose, the water flow is not executed when the sources provide water.
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

species poi {
	string type;
	list<river> closest_river ;
	
	action give_water {
		ask closest_river{water_volume <- 0.004;}
	}
	
	aspect default {
		draw circle(0.00500) color: (type="source") ? #green : #red border: #black;		
	}	
}

species river {
	list<river> neighbor_river ;
	float water_volume;
	float water_volume_from_other;
	
	action water_flow {
//		if (neighbor_river != nil) {
		ask	neighbor_river{			
			water_volume_from_other <- myself.water_volume_from_other + 0.9 * water_volume;
		}
//		}
	}
	
	action update_water_level {
		water_volume <- 0.1 * water_volume + water_volume_from_other;
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
			species poi;			
		}
	}
}
