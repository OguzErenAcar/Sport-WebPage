/*
Navicat SQL Server Data Transfer

Source Server         : MyServer
Source Server Version : 150000
Source Host           : DESKTOP-169T1QH:1433
Source Database       : SporSitesi
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 150000
File Encoding         : 65001

Date: 2021-06-07 23:36:14
*/


-- ----------------------------
-- Table structure for [dbo].[AsistKralligi]
-- ----------------------------
DROP TABLE [dbo].[AsistKralligi]
GO
CREATE TABLE [dbo].[AsistKralligi] (
[id] int NOT NULL ,
[oyucuisim] nvarchar(20) NOT NULL ,
[takimisim] nvarchar(30) NOT NULL ,
[macsayi] int NOT NULL ,
[asistsayi] int NOT NULL ,
[oran] int NOT NULL 
)


GO

-- ----------------------------
-- Records of AsistKralligi
-- ----------------------------

-- ----------------------------
-- Table structure for [dbo].[Galeri]
-- ----------------------------
DROP TABLE [dbo].[Galeri]
GO
CREATE TABLE [dbo].[Galeri] (
[id] int NOT NULL ,
[resimyolu] nvarchar(1) NOT NULL ,
[text] nvarchar(1) NULL ,
[albumno] int NOT NULL 
)


GO

-- ----------------------------
-- Records of Galeri
-- ----------------------------

-- ----------------------------
-- Table structure for [dbo].[GolKralligi]
-- ----------------------------
DROP TABLE [dbo].[GolKralligi]
GO
CREATE TABLE [dbo].[GolKralligi] (
[id] int NOT NULL ,
[oyucuisim] nvarchar(20) NOT NULL ,
[takimisim] nvarchar(30) NOT NULL ,
[macsayi] int NOT NULL ,
[asistsayi] int NOT NULL ,
[oran] int NOT NULL 
)


GO

-- ----------------------------
-- Records of GolKralligi
-- ----------------------------

-- ----------------------------
-- Table structure for [dbo].[haberler]
-- ----------------------------
DROP TABLE [dbo].[haberler]
GO
CREATE TABLE [dbo].[haberler] (
[id] int NOT NULL ,
[baslik] nvarchar(255) NOT NULL ,
[icerik] ntext NULL ,
[Eklenmetarih] datetime NOT NULL ,
[Resimyolu] nvarchar(MAX) NULL ,
[Takimid] int NULL 
)


GO

-- ----------------------------
-- Records of haberler
-- ----------------------------
INSERT INTO [dbo].[haberler] ([id], [baslik], [icerik], [Eklenmetarih], [Resimyolu], [Takimid]) VALUES (N'7', N'Fenerbahçe için flaş teknik direktör yorumu! "Başka çözümü yok".', N'25-26 Haziran''da seçime gitmeye hazırlanan Fenerbahçe''de bir diğer gündem ise yeni teknik direktörün kim olacağı... Son günlerde birçok isimle ilgilendiği iddia edilen sarı-lacivertliler için A Spor yorumcusu Murat Özbostan çarpıcı değerlendirmelerde bulundu. Özbostan, "Ali Koç marka bir teknik direktör getirecek. Bu işin başka çözümü yok." dedi. | Son dakika Fenerbahçe haberleri (FB spor haberi).', N'2021-06-07 21:39:18.207', N'/Upload/Haberler/img/355x250-fenerbahce-icin-flas-teknik-direktor-yorumu-baska-cozumu-yok-1623059547582.jpeg', N'9');
GO
INSERT INTO [dbo].[haberler] ([id], [baslik], [icerik], [Eklenmetarih], [Resimyolu], [Takimid]) VALUES (N'8', N'Son dakika spor haberleri: Beşiktaş Sergen Yalçın''a teklifini iletti! 1 yıllık yeni sözleşme....', N'Beşiktaş''la sezonu çifte kupayla kapatan teknik direktör Sergen Yalçın''ın, siyah-beyazlılarla olan sözleşmesi sona erdi. Beşiktaş Başkanı Ahmet Nur Çebi, yeni mukavele için bu hafta görüşeceklerini ifade ederken siyah-beyazlıların asbaşkanı Emre Kocadağ deneyimli teknik adamla görüştü ve 1 yıllık yeni sözleşme teklif etti. | Son dakika Beşiktaş haberleri (BJK spor haberi)
2020-2021 sezonunu çifte kupayla kapatan Beşiktaş''ta teknik direktör Sergen Yalçın''ın sözleşmesi sona erdi.

Gelecek sezon Devler Ligi''nde yer alacak siyah-beyazlılar deneyimli teknik adamla yola devam etmek isterken, asbaşkan Emre Kocadağ Çeşme''ye gitti ve Sergen Yalçın''la bir görüşme gerçekleştirdi.

Kocadağ''ın 48 yaşındaki teknik adama 1 yıllık yeni sözleşme teklif ettiği öğrenildi.

.', N'2021-06-07 21:41:39.573', N'/Upload/Haberler/img/806x378-son-dakika-spor-haberleri-besiktas-sergen-yalcina-teklifini-iletti-1-yillik-yeni-sozlesme-1623061062152.jpg', N'10');
GO
INSERT INTO [dbo].[haberler] ([id], [baslik], [icerik], [Eklenmetarih], [Resimyolu], [Takimid]) VALUES (N'9', N'Spor Toto Süper Lig ekiplerinden Alanyaspor ile sözleşmesi sona eren ve Beşiktaş''la prensipte anlaştığı iddia edilen Salih Uçan, kulübüne veda etti..', N'Adı transfer döneminde Galatasaray, Trabzonspor ve Beşiktaş''la anılan ve hatta siyah-beyazlı takımla anlaştığı ifade edilen Salih Uçan, sosyal medya hesabından yaptığı paylaşımla Alanyaspor''a veda etti.

27 yaşındaki orta saha oyuncusunun Beşiktaş''la prensipte anlaştığı ifade edilirken siyah-beyazlı kulüple 3 yıllık mukavele yapılacak olan tecrübeli futbolcunun, bonuslarla birlikte sezon başına 10 milyon TL alacağı da aktarıldı.

.
"Birçok takımda forma giydim ve şunu net olarak söyleyebilirim ki; Alanyaspor ilçesi, yönetimi, teknik ekip, idari personeli ve camiası olarak inanılmaz farklı ve özel bir kulüp. Burada çok güzel 2 sene geçirdim. Bana ilk günden itibaren büyük destek oldunuz. Ben de motivasyonumu, disiplinimi ve mücadelemi en üst seviyede tutarak bu formaya hizmet etmeye çalıştım, sahada terimin damlasına kadar savaştım. Ayrıca bana Alanyaspor formasını güvenerek teslim eden Erol Bulut ve Çağdaş Atan hocalarıma da çok teşekkür ediyorum. Tüm yaşadığım anılar, başarılar ve arkadaşlıklar hep kalbimin bir köşesinde yer alacak. Formasını severek büyük bir gurur ile taşıdığım Alanyaspor''a veda ediyorum. Artık benim için bambaşka bir yolculuk başlıyor. Hakkınızı helal edin"

.', N'2021-06-07 22:22:31.603', N'/Upload/Haberler/img/806x378-son-dakika-transfer-haberleri-salih-ucan-alanyaspora-resmen-veda-etti-besiktas-1623052274089.jpeg', N'0');
GO
INSERT INTO [dbo].[haberler] ([id], [baslik], [icerik], [Eklenmetarih], [Resimyolu], [Takimid]) VALUES (N'10', N'EURO 2020''de ilk kez uygulanacak! Elle oynama kuralı....', N'UEFA, Uluslararası Futbol Birliği Kurulu (IFAB) tarafından elle oynama kuralıyla ilgili yapılan değişikliğin, 2020 Avrupa Şampiyonası''nda (EURO 2020) uygulanacağını duyurdu.

UEFA''nın internet sitesinden yapılan açıklamada, 1 Temmuz''da yürürlüğe girecek değişikliklerin, 11 Haziran''da başlayacak EURO 2020''de uygulanacağı belirtildi.

Futbol Oyun Kuralları''nın fauller ve suistimallerle ilgili 12. maddesinde yapılan değişikliklerin yürürlüğe girmesiyle birlikte, oyuncunun elinin/kolunun topa her dokunuşu ihlal olmayacak.

Bir oyuncunun kazara elle oynaması sonucu takım arkadaşının gol atması ya da gol pozisyonuna girmesi artık kural ihlali olarak sayılmayacak.

Yapılan değişikliğe göre elle oynama kuralının ihlal edildiği durumlar ise şöyle:

"Bir oyuncu, elini/kolunu topa doğru hareket ettirerek topa elleri/kollarıyla kasıtlı olarak dokunursa, eli/koluyla doğal olmayan şekilde vücudunu büyüterek elinin/kolunun topa temas etme riskini arttırırsa, kazara bile olsa eliyle/koluyla gol atar ya da eliyle/koluyla topa değdikten sonra gol atarsa, kuralı ihlal eder."

.', N'2021-06-07 22:24:59.120', N'/Upload/Haberler/img/806x378-euro-2020de-ilk-kez-uygulanacak-elle-oynama-kurali-1623053465858.jpg', N'0');
GO
INSERT INTO [dbo].[haberler] ([id], [baslik], [icerik], [Eklenmetarih], [Resimyolu], [Takimid]) VALUES (N'11', N'A Milli Takım, EURO 2020''nin açılış maçında 11 Haziran Cuma günü oynayacağı İtalya maçının hazırlıklarını Almanya''da yaptığı idmanla sürdürdü..', N'A Milli Takım, EURO 2020''nin açılış maçında 11 Haziran Cuma günü oynayacağı İtalya maçının hazırlıklarını Almanya''da yaptığı idmanla sürdürdü.

Ay-yıldızlıların Harsewinkel''de kamp yaptığı Klosterpforte Hotel''in sahasında, teknik direktör Şenol Güneş yönetimindeki antrenmanın ilk 20 dakikası basına açık gerçekleştirildi. Dünkü idmanda sağ üst arka adalesindeki sertleşme nedeniyle takımdan ayrı çalışan Kenan Karaman, bugün takımla çalıştı. Millilerin tam kadro çıktığı idman ısınma koşusuyla başladı, pas ve top kapma çalışmasıyla sürdü. İdmanın basına kapalı bölümünde, İtalya karşılaşmasının taktik çalışması üzerinde duruldu.

Milli takım, hazırlıklarına yarın devam edecek..', N'2021-06-07 22:26:42.170', N'/Upload/Haberler/img/806x378-a-milli-takimda-italya-maci-hazirliklari-surdu-1623090257469.jpg', N'0');
GO
INSERT INTO [dbo].[haberler] ([id], [baslik], [icerik], [Eklenmetarih], [Resimyolu], [Takimid]) VALUES (N'12', N'Son dakika transfer haberleri: Beşiktaşlı Cyle Larin''e çifte talip! Görüşmeler başladı.', N'Beşiktaş ile bu sezon müthiş bir performans ortaya koyan ve çifte şampiyonlukta büyük pay sahibi olan Cyle Larin''e Rusya Ligi takımları talip oldu..
Ajansspor''un haberine göre; CSKA Moskova ve Spartak Moskova''nın, Kanadalı forvet oyuncusunun temsilcisiyle görüşmelere başladığını iddia etti. 26 yaşındaki oyuncunun bonservis bedelinin ise 11 milyon Euro olduğu belirtildi..
TEKLİF REDDEDİLMİŞTİ

Bilindiği üzere oyuncuya ocak ayı transfer döneminde bir İngiliz takımından 15 milyon Euro''luk bir teklif geldiği ancak Ahmet Nur Çebi''nin bu teklifi kabul etmediği açıklanmıştı.
Siyah-beyazlı takımla bu sezon 45 maça çıkan Larin, 23 gol ve 6 asist kaydetti. 26 yaşındaki oyuncunun, Beşiktaş ile olan sözleşmesi 30 Haziran 2022 yılına kadar devam ediyor..

.', N'2021-06-07 22:29:32.387', N'/Upload/Haberler/img/0x0-son-dakika-transfer-haberleri-besiktasli-cyle-larine-cifte-talip-gorusmeler-basladi-1623047216889.jpg', N'10');
GO
INSERT INTO [dbo].[haberler] ([id], [baslik], [icerik], [Eklenmetarih], [Resimyolu], [Takimid]) VALUES (N'13', N'Galatasaray Spor Kulübü Olağan Seçim Genel Kurul Toplantısı’nda kullanılacak oy pusulası için renk seçimi gerçekleştirildi..', N' Galatasaray Kulubü''nün olağan seçimli genel kurul toplantısında kullanılacak oy pusulası için renk seçimi gerçekleştirildi.

Sarı-kırmızılı kulüpten konuyla ilgili yapılan açıklamada şu bilgilere yer verildi:

"Tüzüğümüzün 61. maddesi uyarınca 12-19 Haziran 2021 tarihinde yapılacak olan Galatasaray Spor Kulübü Olağan Seçim Genel Kurul Toplantısı''nda kullanılacak oy pusulaları için renk seçimi, Ali Sami Yen Spor Kompleksi Türk Telekom Stadyumu''nda gerçekleşti.

Galatasaray Spor Kulübü Divan Kurulu Başkanı Aykutalp Derkan''ın kürsüden yaptığı bilgilendirme sonrasında başkan adayları Metin Öztürk (5569), İbrahim Özdemir (7019), Eşref Hamamcıoğlu (7102), Burak Elmas (9320) ve Mehmet Yiğit Şardan (9798) arasında renk seçimine gidildi.

Gerçekleşen renk çekiminin ardından Olağan Seçimli Genel Kurul Toplantısı''nda Metin Öztürk mor, İbrahim Özdemir sarı, Eşref Hamamcıoğlu yeşil, Burak Elmas kırmızı Mehmet Yiğit Şardan ise gri renkli oy pusulası ile yarışacak.".', N'2021-06-07 22:31:35.607', N'/Upload/Haberler/img/806x378-son-dakika-spor-haberleri-galatasarayda-baskanlik-secimi-oncesi-oy-pusulasi-secimi-gerceklesti-1623080491377.jpg', N'8');
GO
INSERT INTO [dbo].[haberler] ([id], [baslik], [icerik], [Eklenmetarih], [Resimyolu], [Takimid]) VALUES (N'14', N'Galatasaray''da kalıp kalmayacağı merak edilen isimlerin başında gelen Emre Akbaba''nın son durumu belli oldu. .', N'atih Terim''in sözleşmesi 31 Mayıs''ta sona erse de iç ve dış transferde tecrübeli hocanın raporu doğrultusunda hareket edildi. Sabah''ın haberine göre Marcao''dan sonra Ömer Bayram ve Emre Akbaba''nın sözleşmesini uzatmaya hazırlanan sarı-kırmızılı kulüp, Aytaç Kara ve Alpaslan Öztürk''le 3''er yıllık ön protokol imzaladı. Terim''in isteği ile 14 Haziran''da toplanacak olan oyuncular, 20-21 Temmuz''daki Şampiyonlar Ligi elemesi için kolları sıvayacak. Kiralıktan dönen Jimmy Durmaz, Jesse Sekidika, Emin Bayram, Yunus Akgün ve Atalay Babacan''ın yanı sıra Emre Kılınç, Oğulcan Çağlayan, Fatih Öztürk, Okan Kocuk da idmanda olacak. Yabancılardan Luyindama, Marcao, Ryan Babel ve Radamel Falcao ise birkaç gün gecikmeyle çalışmalara katılacak..', N'2021-06-07 22:33:04.603', N'/Upload/Haberler/img/806x378-son-dakika-transfer-haberi-galatasarayda-emre-akbaba-karari-sozlesmesi-uzatilacak-mi-1623010991131.jpg', N'8');
GO
INSERT INTO [dbo].[haberler] ([id], [baslik], [icerik], [Eklenmetarih], [Resimyolu], [Takimid]) VALUES (N'15', N'Transfer dönemine hızlı bir giriş yapan Trabzonspor, Bruno Peres ve Gervinho ile sözleşme imzalamıştı. Marek Hamsik''le de transfer görüşmelerini sürdüren bordo-mavililer, Slovak yıldıza ön sözleşme evraklarını gönderdi..', N'Gelecek sezonun transfer çalışmalarına hız veren Trabzonspor, Bruno Peres ve Gervinho''nun ardından bir bomba daha patlatmaya hazırlanıyor.

Bordo-mavili kulüp, Slovak yıldız Marek Hamsik''in transferinde de son aşamaya geldi.

Trabzonspor, Hamsik''e ön sözleşme evraklarını gönderdi. Son anda bir sorun çıkmaması halinde transferin önümüzdeki günlerde resmen açıklanabileceği belirtildi.

.', N'2021-06-07 22:35:03.827', N'/Upload/Haberler/img/806x378-son-dakika-transfer-haberleri-marek-hamsik-adim-adim-trabzonspora-evraklar-gonderildi-1623073284718.jpeg', N'11');
GO
INSERT INTO [dbo].[haberler] ([id], [baslik], [icerik], [Eklenmetarih], [Resimyolu], [Takimid]) VALUES (N'16', N'Fenerbahçe''nin gündemindeki Rafael Benitez''i böyle değerlendirdi! "Çin''e giden hoca niye gelmesin?".', N'Fenerbahçe Başkanı Ali Koç''un Emre Belözoğlu ile devam etmeyeceğini açıklamasının ardından yeni teknik direktörün kim olacağı merak konusu oldu. A Spor yorumcusu Mahmut Alpaslan, Fenerbahçe''nin gündemini değerlendirdi. Alpaslan, sarı-lacivertlilerin teknik adam listesinde bulunan Rafael Benitez için, "Çin''e giden bir hoca niye gelmesin?" şeklinde konuştu..', N'2021-06-07 22:40:16.697', N'/Upload/Haberler/img/benitezz_16_9_1622877018-880x495.jpg', N'9');
GO
INSERT INTO [dbo].[haberler] ([id], [baslik], [icerik], [Eklenmetarih], [Resimyolu], [Takimid]) VALUES (N'17', N'Sao Paulo''da antrenörlük yapan eski Fenerbahçeli Alex de Souza''dan flaş hareket!.', N' Fenerbahçe''nin yaşayan efsanelerinden Alex de Souza, şu anda Brezilya ligi ekiplerinden Sao Paulo''nun altyapısında antrenör olarak görev alıyor. Alex''in Brezilya ekibinde göreve başlaması hem ülkesinde hem de Türkiye''de büyük ses getirmişti. Hoca Alex, çalıştırdığı genç oyuncuların gelişimi için enteresan bir metot uyguladı. İşte detaylar... .

Fenerbahçe''nin heykelini diktiği efsane oyuncusu Alex de Souza, futbolculuk kariyerinin ardından antrenörlüğe soyunmuştu. Ülkesi Brezilya''nın Sao Paulo kulübünün U20 takımında antrenör olarak göreve başlayan Alex, hazırlık maçında Santos ile karşı karşıya geldi. Alex''in takımı maçı başından sonuna kadar domine etti. Skorun 5-0 olmasının ardından Alex enteresan bir karara imza attı. Takımının eksik oynamaya alışması için, bir oyuncusunu bilerek kenara aldı. Bunun üzerine takımı farkı daha da arttırmayı başararak maçı 8-0 kazandı. Mücadelenin ardından Alex de Souza''nın bu kararı çok konuşuldu..', N'2021-06-07 22:41:38.833', N'/Upload/Haberler/img/806x378-son-dakika-spor-haberi-sao-pauloda-antrenorluk-yapan-eski-fenerbahceli-alex-de-souzadan-flas-hareket-1623075660198.jpg', N'9');
GO
INSERT INTO [dbo].[haberler] ([id], [baslik], [icerik], [Eklenmetarih], [Resimyolu], [Takimid]) VALUES (N'18', N'İngiliz devi, Hakan Çalhanoğlu''nun peşinde                                                                                             ', N'
İngiltere Premier Ligi ekiplerinden Arsenal, Martin Odegaard''dan boşalan on numara pozisyonu için Hakan Çalhanoğlu''nu düşünüyor. Serie A''da Milan''la başarılı bir sezon geçiren Hakan için Arsenal antrenörü Arteta''dan onay çıktı. 

Buendia ve Odegaard olmayınca...
CBC Sport''ta çıkan habere göre, on numara arayışlarının sürdüğü Arsenal''de son isim olarak Hakan Çalhanoğlu ileri sürüldü. Norwich''li Emiliano Buendia''nın Aston Villa''ya transfer olması ve Martin Odegaard''ın Real Madrid''e geri dönmesiyle beraber kulübün gündemine Çalhanoğlu alındı. Milli futbolcumuzun Milan''daki sözleşmesinin sona ermesi, diğer kulüpler açısından anlamlı bir opsiyon oluşturuyor.
"Ne yapacağımızı biliyoruz..."
İngiltere''de normal sezonu 8. sırada tamamlayan Arsenal''de gelecek yıl daha iddialı bir kadro için düğmeye basıldı. Kulübün İspanyol teknik direktörü Mikel Arteta, yaz transfer dönemine dair net konuştu. Arteta: "Ne yapacağımıza dair çok net ve çok güçlü fikirlerimiz var. Odegaard bizim futbolcumuz değildi. Real Madrid ile bir görüşme gerçekleştireceğiz. Buna saygı duyacağız." dedi. 

Hakan Çalhanoğlu, AC Milan''la çıktığı 43 maçta 9 gol atarken, 12 asist yaparak yıldızlaşmıştı. Milan''la yeni anlaşmaya varmayan orta saha oyuncunun Juventus ve İngiltere Premier Lig kulüpleriyle görüşme halinde olduğu iddia ediliyor.', N'2021-06-07 22:45:47.677', N'/Upload/Haberler/img/1395798.jpg', N'0');
GO
INSERT INTO [dbo].[haberler] ([id], [baslik], [icerik], [Eklenmetarih], [Resimyolu], [Takimid]) VALUES (N'19', N'Premier Lig''de Manchester United forması giyen Alex Telles, transfer ve geleceği hakkında konuştu. Telles, United''dan ayrılıyor mu? ', N'Telles, United’da kalmak istiyor
Alex Telles, beklenenin aksine Manchester United ile yola devam etmek istediğini söyledi. Futbolcu, gelecek sezon için daha umutlu konuşuyor. 

“Adaptasyon sürecini atlatmak kolay olmadı”
Telles, “Manchester United’da ilk sezonumdu ve gerçekten mutluyum. Eminim ki gelecek sezon daha da iyi olacak. İyi maçlar çıkardım. İlk sezon adaptasyon sürecini atlatmak kolay olmadı. Ama Ole Gunnar Solksjaer bana destek oldu, güveni de ve ben de sahaya çıktığımda elimden gelenin en iyisini yaptığımı düşünüyorum” dedi. 

Daha fazla süre almak istiyor
Ayrıca Telles daha fazla süre almak istediğinin de altını çizdi. Telles, “Eminim ki yeni sezonda daha fazla süre alacağım. Ben daha fazla süre almak ve başarılı olmak için en iyisini yapmaya devam edeceğim” ifadelerini kullandı. 

Galatasaray’a da kazandırmıştı
Daha önce Galatasaray forması da giyen Alex Telles, son sezonunda Luke Shaw''un gölgesinde kaldı. Futbolcu, United formasıyla 26 maça çıktı ve 4 asist yaptı. Telles’in Porto sonrası United’a geçişiyle birlikte Galatasaray da futbolcunun transferinden yaklaşık 1 milyon Euro gelir elde etmişti. ', N'2021-06-07 22:47:51.657', N'/Upload/Haberler/img/1259678.jpg', N'8');
GO
INSERT INTO [dbo].[haberler] ([id], [baslik], [icerik], [Eklenmetarih], [Resimyolu], [Takimid]) VALUES (N'20', N'İspanya Ligi takımlarından FC Barcelona, Olimpik Lyon ile sözleşmesi sona eren Memphis Depay''a yeni sözleşme teklifinde bulundu.               ', N'Yeni sözleşme
İtalyan gazeteci Fabrizio Romano''nun haberine göre; Katalan devi, Gini Wijnaldum''da yaşadığı sorunu yaşamamak için Hollandalı oyuncu Depay''a iyileştirilmiş yeni bir sözleşme teklifi yaptı. Bilindiği üzere PSG, Wijnaldum''a Barcelona''nın teklif ettiğini iki katını önermiş, Hollandalı oyuncu da İspanyol ekibinin teklifini geri çevirmişti. 

 
Haberde, İspanyol ekibinin 27 yaşındaki forvet oyuncuyla 2024 yılına kadar sözleşme imzalayacağı ve resmi açıklamanın kısa sürede tamamlanacağı belirtildi.

', N'2021-06-07 22:50:32.407', N'/Upload/Haberler/img/1419280.jpg', N'0');
GO
INSERT INTO [dbo].[haberler] ([id], [baslik], [icerik], [Eklenmetarih], [Resimyolu], [Takimid]) VALUES (N'21', N'Transfere hızlı başlayan ve kadrosunu bir forvetle takviye etmek isteyen Trabzonspor, Ludogorets’te forma giyen Jakub Swierczok’u gündemine aldı.', N'Polonya Ligi''nde adından söz ettirdi
Bulgar medyasında yer alan habere göre Trabzonspor, Ludogorets'' te forma giyen Polonyalı Jakub Swierczok’un peşinde. Geçtiğimiz sezon ülkesinde Piast Gliwice''de kiralık oynayan 28 yaşındaki futbolcu, attığı gollerle dikkat çekti. 
Hem forvet hem 10 numara
Piast Gliwice formasıyla oynadığı toplam 28 maçta 17 gol, 3 asistlik performans sergileyen Polonyalı için Karadeniz ekibinin Bulgar kulübüne resmi teklifte bulunduğu belirtildi. Golcü futbolcu, santrfor pozisyonunun dışında 10 numara olarak da oynayabiliyor.
Swierczok, Avcı''nın B planı mı?
Trabzonspor Teknik Direktörü Abdullah Avcı, geçtiğimiz günlerde beIN Sports’a verdiği röportajda 5 takviye yapmak istediklerini açıklamıştı. Bordo-mavili teknik adam, forvet transferi için eski gol kralları Alexander Sörloth ile ilgilendiklerini dile getirerek, "Sörloth keşke olsa. Başkanımız konu ile ilgili çalışma yapıyor. Bekleyelim görelim. Sörloth''u bekleyeceksek, ben beklemeye razıyım. Olabiliyorsa bizi mutlu eder, olamıyorsa B planına hazırlık yapıyoruz" diye konuşmuştu.', N'2021-06-07 22:52:31.317', N'/Upload/Haberler/img/1418746.jpg', N'11');
GO

-- ----------------------------
-- Table structure for [dbo].[Katagori]
-- ----------------------------
DROP TABLE [dbo].[Katagori]
GO
CREATE TABLE [dbo].[Katagori] (
[id] int NOT NULL ,
[katagori] nvarchar(16) NULL ,
[Aktifmi] bit NOT NULL ,
[Link] nvarchar(60) NULL ,
[Parentid] int NULL 
)


GO

-- ----------------------------
-- Records of Katagori
-- ----------------------------
INSERT INTO [dbo].[Katagori] ([id], [katagori], [Aktifmi], [Link], [Parentid]) VALUES (N'1', N'Anasayfa', N'1', N'/Home', null);
GO
INSERT INTO [dbo].[Katagori] ([id], [katagori], [Aktifmi], [Link], [Parentid]) VALUES (N'2', N'Takımlar', N'1', N'', null);
GO
INSERT INTO [dbo].[Katagori] ([id], [katagori], [Aktifmi], [Link], [Parentid]) VALUES (N'3', N'İstatistikler', N'1', N'#', null);
GO
INSERT INTO [dbo].[Katagori] ([id], [katagori], [Aktifmi], [Link], [Parentid]) VALUES (N'4', N'Puan Durumu', N'1', N'	 /PuanDurumu/PuanDurumu', null);
GO
INSERT INTO [dbo].[Katagori] ([id], [katagori], [Aktifmi], [Link], [Parentid]) VALUES (N'5', N'Haberler', N'1', N'/Haber/Haberler', null);
GO
INSERT INTO [dbo].[Katagori] ([id], [katagori], [Aktifmi], [Link], [Parentid]) VALUES (N'6', N'Galeri', N'1', N'#', null);
GO
INSERT INTO [dbo].[Katagori] ([id], [katagori], [Aktifmi], [Link], [Parentid]) VALUES (N'7', N'Hakkımızda', N'1', N'/Home/Hakkimizda', null);
GO
INSERT INTO [dbo].[Katagori] ([id], [katagori], [Aktifmi], [Link], [Parentid]) VALUES (N'8', N'İletişim', N'1', N'/Home/İletisim', null);
GO
INSERT INTO [dbo].[Katagori] ([id], [katagori], [Aktifmi], [Link], [Parentid]) VALUES (N'9', N'Galatasaray', N'1', N'/Haber/Haberler/8', N'2');
GO
INSERT INTO [dbo].[Katagori] ([id], [katagori], [Aktifmi], [Link], [Parentid]) VALUES (N'10', N'Fenerbahçe', N'1', N'/Haber/Haberler/9', N'2');
GO
INSERT INTO [dbo].[Katagori] ([id], [katagori], [Aktifmi], [Link], [Parentid]) VALUES (N'11', N'Beşiktaş', N'1', N'/Haber/Haberler/10', N'2');
GO
INSERT INTO [dbo].[Katagori] ([id], [katagori], [Aktifmi], [Link], [Parentid]) VALUES (N'12', N'Trabzonspor', N'1', N'/Haber/Haberler/11', N'2');
GO

-- ----------------------------
-- Table structure for [dbo].[Ligler]
-- ----------------------------
DROP TABLE [dbo].[Ligler]
GO
CREATE TABLE [dbo].[Ligler] (
[id] int NOT NULL ,
[ligisim] nvarchar(1) NOT NULL ,
[Logoyolu] nvarchar(1) NOT NULL 
)


GO

-- ----------------------------
-- Records of Ligler
-- ----------------------------

-- ----------------------------
-- Table structure for [dbo].[Puandurumu]
-- ----------------------------
DROP TABLE [dbo].[Puandurumu]
GO
CREATE TABLE [dbo].[Puandurumu] (
[id] int NOT NULL ,
[Takimisim] nvarchar(60) NOT NULL ,
[OynananMac] nvarchar(4) NOT NULL ,
[Galibiyet] nvarchar(4) NOT NULL ,
[Beraberlik] nvarchar(4) NOT NULL ,
[Malubiyet] nvarchar(4) NOT NULL ,
[AtilanGol] nvarchar(4) NOT NULL ,
[YenilenGol] nvarchar(4) NOT NULL ,
[Avaraj] nvarchar(4) NOT NULL ,
[Puan] nvarchar(4) NOT NULL 
)


GO

-- ----------------------------
-- Records of Puandurumu
-- ----------------------------
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'1', N'1.BEŞİKTAŞ A.Ş.', N'40', N'26', N'6', N'8', N'89', N'44', N'45', N'84');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'2', N'2.GALATASARAY A.Ş.', N'40', N'26', N'6', N'8', N'80', N'36', N'44', N'84');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'3', N'3.FENERBAHÇE A.Ş.', N'40', N'25', N'7', N'8', N'72', N'41', N'31', N'82');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'4', N'4.TRABZONSPOR A.Ş.', N'40', N'19', N'14', N'7', N'50', N'37', N'13', N'71');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'5', N'5.DEMİR GRUP SİVASSPOR', N'40', N'16', N'17', N'7', N'54', N'43', N'11', N'65');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'6', N'6.ATAKAŞ HATAYSPOR', N'40', N'17', N'10', N'13', N'62', N'53', N'9', N'61');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'7', N'7.AYTEMİZ ALANYASPOR', N'40', N'17', N'9', N'14', N'58', N'45', N'13', N'60');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'8', N'8.FATİH KARAGÜMRÜK A.Ş.', N'40', N'16', N'12', N'12', N'64', N'52', N'12', N'60');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'9', N'9.GAZİANTEP FUTBOL KULÜBÜ A.Ş.', N'40', N'15', N'13', N'12', N'59', N'51', N'8', N'58');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'10', N'10.GÖZTEPE A.Ş.', N'40', N'13', N'12', N'15', N'59', N'59', N'0', N'51');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'11', N'11.İTTİFAK HOLDİNG KONYASPOR', N'40', N'12', N'14', N'14', N'49', N'48', N'1', N'50');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'12', N'12.MEDİPOL BAŞAKŞEHİR FK', N'40', N'12', N'12', N'16', N'43', N'55', N'-12', N'48');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'13', N'13.ÇAYKUR RİZESPOR A.Ş.', N'40', N'12', N'12', N'16', N'53', N'69', N'-16', N'48');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'14', N'14.KASIMPAŞA A.Ş.', N'40', N'12', N'10', N'18', N'47', N'57', N'-10', N'46');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'15', N'15.HELENEX YENİ MALATYASPOR', N'40', N'10', N'15', N'15', N'49', N'53', N'-4', N'45');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'16', N'16.FRAPORT-TAV ANTALYASPOR', N'40', N'9', N'17', N'14', N'41', N'55', N'-14', N'44');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'17', N'17.HES KABLO KAYSERİSPOR', N'40', N'9', N'14', N'17', N'35', N'52', N'-17', N'41');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'18', N'18.BÜYÜKŞEHİR BELEDİYE ERZURUMSPOR', N'40', N'10', N'10', N'20', N'44', N'68', N'-24', N'40');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'19', N'19.MKE ANKARAGÜCÜ', N'40', N'10', N'8', N'22', N'46', N'65', N'-19', N'38');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'20', N'20.GENÇLERBİRLİĞİ', N'40', N'10', N'8', N'22', N'44', N'76', N'-32', N'38');
GO
INSERT INTO [dbo].[Puandurumu] ([id], [Takimisim], [OynananMac], [Galibiyet], [Beraberlik], [Malubiyet], [AtilanGol], [YenilenGol], [Avaraj], [Puan]) VALUES (N'21', N'21.YUKATEL DENİZLİSPOR', N'40', N'6', N'10', N'24', N'38', N'77', N'-39', N'28');
GO

-- ----------------------------
-- Table structure for [dbo].[Slider]
-- ----------------------------
DROP TABLE [dbo].[Slider]
GO
CREATE TABLE [dbo].[Slider] (
[id ] int NOT NULL ,
[EklenmeTarihi ] datetime NOT NULL ,
[Resim] nvarchar(500) NULL ,
[Baslik] nvarchar(200) NULL ,
[Link] nvarchar(100) NULL 
)


GO

-- ----------------------------
-- Records of Slider
-- ----------------------------
INSERT INTO [dbo].[Slider] ([id ], [EklenmeTarihi ], [Resim], [Baslik], [Link]) VALUES (N'2', N'2021-06-06 13:19:33.000', N' /Upload/Slider/img/sondk.jpg', N' ', N'#');
GO
INSERT INTO [dbo].[Slider] ([id ], [EklenmeTarihi ], [Resim], [Baslik], [Link]) VALUES (N'3', N'2021-06-07 23:14:10.000', N' /Upload/Slider/img/fb.jpg', null, null);
GO
INSERT INTO [dbo].[Slider] ([id ], [EklenmeTarihi ], [Resim], [Baslik], [Link]) VALUES (N'4', N'2021-06-07 23:15:14.000', N' /Upload/Slider/img/uefa.jpg', null, null);
GO
INSERT INTO [dbo].[Slider] ([id ], [EklenmeTarihi ], [Resim], [Baslik], [Link]) VALUES (N'7', N'2021-06-07 23:06:26.753', N'/Upload/Slider/img/e21835698e044514b242a0ec79b0b991.jpg', N'Anadolu Efes şampiyonu oldu.', null);
GO

-- ----------------------------
-- Table structure for [dbo].[Users]
-- ----------------------------
DROP TABLE [dbo].[Users]
GO
CREATE TABLE [dbo].[Users] (
[id] int NOT NULL ,
[Ad] nvarchar(60) NOT NULL ,
[Soyad] nvarchar(60) NOT NULL ,
[Parola] nvarchar(100) NOT NULL ,
[Email] nvarchar(100) NOT NULL ,
[KucukResimYolu] nvarchar(200) NOT NULL ,
[EklenmeTarih] datetime NOT NULL ,
[Rol] int NOT NULL 
)


GO

-- ----------------------------
-- Records of Users
-- ----------------------------
INSERT INTO [dbo].[Users] ([id], [Ad], [Soyad], [Parola], [Email], [KucukResimYolu], [EklenmeTarih], [Rol]) VALUES (N'1', N'admin', N'admin', N'0DPiKuNIrrVmD8IUCuw1hQxNqZc=', N'admin', N'#', N'2021-06-03 21:10:08.000', N'1');
GO

-- ----------------------------
-- Indexes structure for table AsistKralligi
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[AsistKralligi]
-- ----------------------------
ALTER TABLE [dbo].[AsistKralligi] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table Galeri
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[Galeri]
-- ----------------------------
ALTER TABLE [dbo].[Galeri] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table GolKralligi
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[GolKralligi]
-- ----------------------------
ALTER TABLE [dbo].[GolKralligi] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table haberler
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[haberler]
-- ----------------------------
ALTER TABLE [dbo].[haberler] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table Katagori
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[Katagori]
-- ----------------------------
ALTER TABLE [dbo].[Katagori] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table Ligler
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[Ligler]
-- ----------------------------
ALTER TABLE [dbo].[Ligler] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table Puandurumu
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[Puandurumu]
-- ----------------------------
ALTER TABLE [dbo].[Puandurumu] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table Slider
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[Slider]
-- ----------------------------
ALTER TABLE [dbo].[Slider] ADD PRIMARY KEY ([id ])
GO

-- ----------------------------
-- Indexes structure for table Users
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[Users]
-- ----------------------------
ALTER TABLE [dbo].[Users] ADD PRIMARY KEY ([id])
GO
