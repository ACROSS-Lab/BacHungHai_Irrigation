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
	geometry shape <- envelope(river_shape_file);
	Station source;
	Station dest;
	graph the_river; //	poi outlet;
 init {
		create river from: river_shape_file;
		create poi from: poi_file {
			shape <- circle(0.00500);
		}

		create Station from: tram_mua_shapefile;
		source <- first(Station where (each.Name = "Song Hong"));
		dest <- first(Station where (each.Name = "Song Thai Binh"));
		the_river <- as_edge_graph(river);
		ask river {
			mypoi <- poi where (each intersects self);
		}

		ask poi {
			rivers <- river where (each overlaps self);
			write self;
			write rivers;
		}

		ask source {
			do give_water;
		}

	}
	//	reflex water_regen when:cycle mod 1000=0{
 //		ask source{
 //			do give_water;
 //		}
 //		ask dest{
 //			do give_water;
 //		}
 //	} 

}

species poi {
	string type;
	list<river> rivers <- [];

	aspect default {
		draw shape color: (type = "source") ? #green : #red border: #black;
	}

}

species water skills: [moving] {
	river myriver;
	point target;
	rgb color <- #blue;
	float size <- 0.02;
	float sp <- 0.002;
	geometry shape <- triangle(size); //	int flag <- 0;
 aspect default {
		draw shape color: color rotate: heading ;
	}

	reflex movement {
		do goto on: the_river target: target speed: sp;
		if (target != nil and location =target ){//distance_to target <= (sp)) {
			poi p<-myriver.mypoi closest_to self;
			loop r over:p.rivers-myriver{
				if(length(r.mypoi)>1){
					loop p1 over:r.mypoi-p{						
						create water{
							myriver<-r;
							location<-p.location;
							target<-p1.location;
						}
					}
				}
				
			}
			do die();
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

	action give_water {
		ask river at_distance 0.1 {
			if (length(mypoi) > 1) {
				river r <- self;
				poi p <- mypoi closest_to myself;
				loop p1 over: mypoi - p {
					create water {
						myriver <- r;
						location <- p.location;
						target <- p1.location;
					}

				}

			}

		}

	}
	//	action give_water {
	//		ask river at_distance 0.1 {
	//			water_volume <- 0.001;
	//		}
	//
	//	}
	aspect default {
		draw shape color: #red;
		draw circle(rad) color: #red empty: true;
		draw Name + " " + " " + TL_level + " " + HL_level size: 10 at: location + 0.002 color: #red;
		if (TL_area != nil) {
			draw TL_area color: #green;
		}

		if (HL_area != nil) {
			draw HL_area color: #green;
		}

	}

}

species river {
	list<poi> mypoi <- [];
	//	list<river> neighbor_river;
	//	float water_volume;
	//	float water_volume_from_other;

	//	action water_flow {
	//		ask neighbor_river {
	//			water_volume_from_other <- water_volume_from_other + 0.19 * myself.water_volume;
	//		}
	//
	//	}
	//
	//	action update_water_level {
	//		water_volume <- water_volume +  0.16 *water_volume_from_other;
	//		water_volume_from_other <- 0.0;
	//	}
	aspect default {
		draw shape color: #blue;
		//		draw shape + water_volume color: #blue;
	}

}

experiment flow type: gui {
	output {
		display "Water Unit" {
			species river;
			species poi;
			species Station;
			species water;
		}

	}

}
