

// test
Console.WriteLine(Rgb(255,255,255));
Console.WriteLine(Rgb(255,255,300));
Console.WriteLine(Rgb(0,0,0));
Console.WriteLine(Rgb(148,0,211));
Console.WriteLine(Rgb(148,-20,211));
Console.WriteLine(Rgb(144,195,212));
Console.WriteLine(Rgb(212,53,12));


// decision
string Rgb(int r, int g, int b) 
  {
      if (r > 255) r = 255;
      if (g > 255) g = 255;
      if (b > 255) b = 255;
      
      if (r < 0) r = 0;
      if (g < 0) g = 0;
      if (b < 0) b = 0;
            
      return $"{r:X2}{g:X2}{b:X2}";
  }