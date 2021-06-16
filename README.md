# WinForm-KeyLogger

Uygulamamız KeyLogger ve aynı zamanda uzak makine kontrol uygulamasıdır. Uygulama içerisinde 3 adet proje yer almaktadır.

1-) Server Uygulaması 
    Bağlanılacak yani uzaktan kontrol edilecek, tuşları dinlenecek bilgisayarda çalıştırılacak uygulamadır. Çalıştırıldığı makinenin ekran görüntüsü ve basılan tuşlarını 
    Client uygulamasına göndermektedir. Bağlantı devam ettiği sürece Server uygulaması çalışır durumda olmalıdır.
    
2-) Client Uygulaması
    Bağlanılan makineyi yönetmek amacıyla kullanılan yönetim uygulamasıdır. Bağlantı için Server uygulamasının çalıştığı makinenin IP adresi metin kutusuna girilmeli ve 
    Bağlan butonuna basılmalıdır. Bağlantı sağlandıktan sonra uzak makinede basılan tuşlar alınabilecek ve uzak makinenin klavye ve faresi kontrol edilebilecektir.
    
3-) RemoteObject
    Remoting teknolojisinde paylaşılan nesnedir.
    
Not: Client ve Server uygulamasının çalıştırıldığı makineler aynı intranette olmalıdır.
    
Projemde Remoting teknolojisi Http protokolu üzerinden kullanılmaktadır. Ayrıca KeyLogger işlemlerinde Windows Api'lerden faydalanılmıştır.


![Screenshot](http://www.ibrahimarac.com/gitimages/keylogger/keylogger-1.png)
