# CardPassApp

Yan Görünüş

![1](https://github.com/eren5854/CardPassApp/assets/57590401/27107313-9524-47b9-b3ae-2d3faebe2d32)


Arka Görünüş

![2](https://github.com/eren5854/CardPassApp/assets/57590401/d009c465-6c52-442d-af23-9db284124a9b)


Ön Görünüş

![3](https://github.com/eren5854/CardPassApp/assets/57590401/3db39cfa-1c66-48bc-9e2a-167c2d2a43f9)


İç Kısım

![4](https://github.com/eren5854/CardPassApp/assets/57590401/7ff77e02-9cf7-4837-a9d2-4e59778207d8)

STL VE SOLIDWORKS dosyaları indirdikten sonra 3d yazıcıdan baskı alabilirsiniz yada tasarımı
zevkinize göre düzenleyebilirsiniz.

Bağlantı Şeması:

RFID  SDA    =>  Nodemcu  D4      
RFID  SCL    =>  Nodemcu  D5      
RFID  MOSI   =>  Nodemcu  D7     
RFID  MISO   =>  Nodemcu  D6
RFID  IRQ    =>  BOŞ
RFID  GND    =>  Nodemcu  G       
RFID  RST    =>  BOŞ    
RFID  3.3V   =>  Nodemcu  3V      


nodemcu_rfid.ino dosyasını arduino ide yazılımı ile açıldıktan sonra Dosya > Tercihler > Ek devre kartları yöneticisi kısmına aşağıdakı satırı kopyalayıp yapıştırın.
https://arduino.esp8266.com/stable/package_esp8266com_index.json
Araçlar > Kart > Kart Yöneticisi tıklayarak kart yöneticisini açın ardından arama yerine esp8266 yazın gelen seçenekte en son versiyonu seçip kurun.
Talak > library ekle > kütüphaneleri yönet kısmına tıklayın ardından arama yerine MFRC522 yazın 

