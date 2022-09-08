
function acSolMenu(){
	document.getElementById("solMenuNav").style.width="250px";
	document.getElementById("main").style.marginLeft="250px";
	//document.body.style.backgroundColor="rgba(0,0,0,0.4)";
}


function kapatSolMenu(){
	document.getElementById("solMenuNav").style.width="0px";
	document.getElementById("main").style.marginLeft="0px";
	//document.body.style.backgroundColor="#FFF";
}
var myCarousel = document.querySelector('#carouselExampleIndicators')

	var carousel = new bootstrap.Carousel(myCarousel, {
		interval: 2500,
		wrap: true
	});

	 function gizleme(){

		if(scrollY>30){

			document.getElementById("navbarust").style.display="none";
		}
		else
		document.getElementById("navbarust").style.display="block";


	}



