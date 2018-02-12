#include "DHT.h"
#include <LiquidCrystal.h>

#define DHTPIN 22

#define DHTTYPE DHT11

DHT dht(DHTPIN, DHTTYPE);

const int rs = 12, en = 11, d4 = 5, d5 = 4, d6 = 3, d7 = 2;
LiquidCrystal lcd(rs, en, d4, d5, d6, d7); 

void setup() {
  // put your setup code here, to run once:
  lcd.begin(16,2);
  lcd.print("Reading sensor");
  dht.begin();

}

void loop() {
  // put your main code here, to run repeatedly:
  float temperature, humidity;

  humidity = dht.readHumidity();
  temperature = dht.readTemperature();
  delay(2000);

  lcd.clear();

  char tempF[6];
  char humF[6];
  dtostrf(temperature, 5, 1, tempF);
  dtostrf(humidity, 2, 0, humF);

  lcd.print("T:");
  lcd.print(tempF);
  lcd.print((char)223);
  lcd.print("C ");
  lcd.print("H: ");
  lcd.print(humF);
  lcd.print("%");

}
