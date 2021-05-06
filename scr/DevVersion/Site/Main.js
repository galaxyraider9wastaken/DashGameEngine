let canvas, ctx;
canvas = document.getElementById('canvas');
ctx = canvas.getContext('2d');

class Sprite {
  constructor(x, y, w, h, img){
    this.x = x;
    this.y = y;
    this.w = w;
    this.h = h;
    this.img = img;
  } 
}

var sprites = [];
var SAmount = 0;
function Draw(x, y, w, h, path){
  var image = new Image(w, h);
  image.src = path;
  sprites[SAmount] = new Sprite(x, y, w, h, image);
  SAmount+=1;
}

function Main(){
  var i =0;
  for(i =0;i<sprites.length;i++){
    ctx.drawImage(sprites[i].img, sprites[i].x, sprites[i].y, sprites[i].w, sprites[i].h);
  }
} setInterval(function(){ 
    Main()
}, 1);
