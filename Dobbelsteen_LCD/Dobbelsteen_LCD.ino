#include <Wire.h>
#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x27,16,2);  // set the LCD address to 0x27 for a 20 chars and 2 line display


const unsigned int MAX_MESSAGE_LENGTH = 12;

void setup()
{
  Serial.begin(9600);
  lcd.init();                      // initialize the lcd 
  lcd.backlight();
  lcd.setCursor(0,0);
  lcd.print("LCD initialised");
  delay(1000);
  lcd.clear();
}


void loop()
{
   while (Serial.available() >0){          
   int getButton = Serial.parseInt();
    Serial.read(); 
      if ( getButton == 31){    //31 omdat als je bv 2 zou rollen je anders de 2de if zou aflopen
        lcd.setCursor(0,0);
        lcd.print(" ");  
          int Dobbelsteen1 = Serial.parseInt(); 
          lcd.setCursor(0,0);
          lcd.print(Dobbelsteen1);
      }
      if (getButton == 32){
        lcd.setCursor(5,0);
        lcd.print(" ");  
          int Dobbelsteen2 = Serial.parseInt(); 
          lcd.setCursor(5,0);
          lcd.print(Dobbelsteen2);
      }
      if (getButton == 33){
        lcd.setCursor(9,0);
        lcd.print(" ");  
          int Dobbelsteen3 = Serial.parseInt(); 
          lcd.setCursor(9,0);
          lcd.print(Dobbelsteen3);
      }
      if (getButton == 34){
        lcd.clear();
      }
  } 
}
