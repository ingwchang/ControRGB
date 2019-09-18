int rojo = 11;
int verde = 9;
int azul = 10;

 
int baud = 9600;
 

int time = 1000;
 
void setup()
{
  
 
 
  Serial.begin(baud);
 
  pinMode(rojo, OUTPUT);
pinMode(verde,OUTPUT);
pinMode(azul,OUTPUT);
}
 
// the loop routine runs over and over and over and over
void loop()
//loop constantly scans for serial input
{
  
  if (Serial.available() > 0)
  {
    
    int val = Serial.read();
    
    if (val == '1')
    {
      analogWrite(rojo,255);
analogWrite(verde, 0);
analogWrite(azul,0);  
    }
    if (val == '3')
    {
      analogWrite(rojo,255);
analogWrite(verde, 140);
analogWrite(azul,0);  
    }
    if (val == '2')
    {
     analogWrite(rojo,102);
     analogWrite(verde,205);
     analogWrite(azul,170);  
    }
    if (val == '4')
    {
      analogWrite(rojo,255);
analogWrite(verde, 215);
analogWrite(azul,0);  
    }
    if (val == '5')
    {
      analogWrite(rojo,0);
analogWrite(verde, 128);
analogWrite(azul,0);  
    }
    if (val == '6')
    {
      analogWrite(rojo,127);
analogWrite(verde, 255);
analogWrite(azul,0);  
    }
    if (val == '7')
    {
      analogWrite(rojo,240);
analogWrite(verde,230);
analogWrite(azul,140);  
    }
    if (val == '8')
    {
      analogWrite(rojo,255);
analogWrite(verde, 20);
analogWrite(azul,147);  
    }
    if (val == '9')
    {
      analogWrite(rojo,0);
analogWrite(verde, 0);
analogWrite(azul,255);  
    }
    if (val == '0')
    {
      analogWrite(rojo,64);
analogWrite(verde, 224);
analogWrite(azul,208);  
    } 
    if (val == 'a')
    {
      analogWrite(rojo,255);
analogWrite(verde, 20);
analogWrite(azul,147);  
    }
    if (val == 'b')
    {
      analogWrite(rojo,240);
analogWrite(verde, 128);
analogWrite(azul,128);  
    }
    //flush the serial value
    Serial.flush();
  }
}
