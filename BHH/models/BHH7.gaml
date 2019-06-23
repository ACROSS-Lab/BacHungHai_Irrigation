model Waterflowrivergraph

global {
	file river_shape_file <- shape_file("../includes/river_simple3.shp");
	file poi_file <- shape_file("../includes/river_poi.shp");
	file tram_mua_shapefile <- file("../includes/TramMua.shp");

	geometry shape <- envelope(river_shape_file) +0.01;
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
//		 	write "add water";
			ask source  {
				do give_water;
			}	
			ask dest{
				do give_water;
			}
		 }
//		  else {	

		 if (every(1#cycles)) {	
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
		ask river overlapping self{water_volume <-water_volume+ 0.008;}
	}

	action take_water {
		ask river overlapping self{water_volume <-water_volume -0.0004;}
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
//	list<river> previous<-[];
	list<river> neighbor_river ;
	float water_volume;
	float water_volume_from_other;
	float evapo_rate<-0.0005;
	action water_flow {
		float avg<-(water_volume+sum(neighbor_river collect each.water_volume)) / (1+ length(neighbor_river));
		water_volume_from_other<-avg;
//		float avg<-water_volume / length(neighbor_river-self);
//		ask	neighbor_river - self -previous{		
//			if(not(self in previous)){
//				previous<+self;
//			}	
//			water_volume_from_other <- water_volume_from_other + 0.5*myself.water_volume;
//		}
	}
	
	action update_water_level {
//		float avg<-(water_volume+sum(neighbor_river collect each.water_volume)) / (1+ length(neighbor_river));
//		ask	neighbor_river - self {		
////			if(not(self in previous)){
////				previous<+self;
////			}	
//			water_volume <- water_volume_from_other;
////			water_volume_from_other <- water_volume_from_other + 0.5*myself.water_volume;
//		}
		water_volume <- water_volume_from_other;
//		water_volume <- avg;// water_volume + water_volume_from_other;
		water_volume<-water_volume>0.004?0.004:water_volume;
		water_volume_from_other <- 0.0;
	}
	reflex evapo{
//		water_volume<-water_volume-evapo_rate*rnd(1)*water_volume;
	}
	
	aspect default {
		draw shape color: #blue;	
		draw shape + water_volume color: #blue;
		
			
	}
}

experiment flow type: gui {
	output {
		layout #split navigator:false parameters:false consoles:false;
	 	display "Water flow" { 
			species river ; 
//			species poi;
			species Station;			
		}
	}
}
