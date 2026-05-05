using IncirDesignRevize1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace IncirDesignRevize1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details(int id)
        {
            var model = new ProductDetailViewModel();

            if (id == 1)
            {
                model.Id = 1;
                model.UrunAdi = "Atatürk Temalı Özel Tasarım Okey Takımı";
                model.Resim = "/img/urunler/ataturk.png";
                model.Fiyat = "2500 TL";
                model.ProductDescription = "Cumhuriyetimizin kurucusu Mustafa Kemal Atatürk’ün asil duruşunu ve ilham veren liderliğini yansıtan bu özel tasarım okey ıstakası, oyun keyfinizi estetikle buluşturur. Yüksek kaliteli malzeme kullanılarak üretilen bu ürün, dayanıklılığı ve şık görünümü ile uzun yıllar kullanım imkanı sunar. Üzerindeki detaylı baskı sayesinde hem anlamlı hem de dikkat çekici bir tasarıma sahiptir. 🎯 Neden Bu Ürün? Sadece bir oyun aracı değil, aynı zamanda değerlerimizi yansıtan anlamlı bir tasarım ürünüdür. Kendiniz için alabilir ya da sevdiklerinize özel ve anlamlı bir hediye olarak tercih edebilirsiniz.";
                model.Stock = 3;
            }
            else if (id == 2)
            {
                model.Id = 2;
                model.UrunAdi = "İsim Yazılı Kişiye Özel Tasarım Okey Takımı";
                model.Resim = "/img/urunler/isim.png";
                model.Fiyat = "2500 TL";
                model.ProductDescription = "Kendinize ya da sevdiklerinize özel, tamamen kişiselleştirilebilir bu okey takımı ile oyun keyfini bir üst seviyeye taşıyın. Üzerine istediğiniz isim, tarih veya özel mesaj eklenebilen bu tasarım, hem anlamlı hem de şık bir kullanım sunar. Yüksek kaliteli malzeme ile üretilen okey takımı, uzun ömürlü kullanım sağlarken estetik görünümüyle de dikkat çeker. Özel baskı teknolojisi sayesinde yazılar silinmez, solmaz ve ilk günkü canlılığını korur.  🎯 Neden Tercih Etmelisiniz?  Bu ürün sadece bir oyun takımı değil, aynı zamanda özel anları ölümsüzleştiren anlamlı bir hediyedir. Doğum günü, yıl dönümü veya özel günler için mükemmel bir seçimdir.arak tercih edebilirsiniz.";
                model.Stock = 7;
            }
            else if (id == 3)
            {
                model.Id = 3;
                model.UrunAdi = "Turan Özel Seri: Kurt Figürlü Özel Tasarım Okey Seti";
                model.Resim = "/img/urunler/kurt.png";
                model.Fiyat = "2500 TL";
                model.ProductDescription = "Türk kültürünün sarsılmaz sembolü Bozkurt figürüyle taçlandırılmış, asalet ve gücü bir araya getiren özel tasarım okey takımı. Turan özel serimizin bir parçası olan bu set, sadece bir oyun aracı değil; masanıza karakter katacak bir koleksiyon parçasıdır. Geleneksel motiflerin modern dijital baskı teknolojisiyle buluştuğu ıstaka arkası tasarımlar, yüksek çözünürlüğü ve canlı renkleriyle dikkat çeker.";
                model.Stock = 3;
            }
            else if (id == 4)
            {
                model.Id = 4;
                model.UrunAdi = "Pink Dream Serisi: Barbie Temalı Özel Tasarım Okey Takımı";
                model.Resim = "/img/urunler/barbie.png";
                model.Fiyat = "2500 TL";
                model.ProductDescription = "Hi Barbie! Okey masasına biraz pembe sihir ve ikonik bir tarz katmaya ne dersin? Barbie’nin rüya dünyasından ilham alan bu özel tasarım okey takımı, oyun gecelerinizi bir moda şovuna dönüştürüyor. Canlı pembe tonları, ışıltılı detaylar ve ikonik Barbie silüetiyle bezenmiş ıstakalar, hem şıklığı hem de eğlenceyi bir araya getiriyor.";
                model.Stock = 1;
            }
            else if (id == 5)
            {
                model.Id = 5;
                model.UrunAdi = "Ötüken Serisi:Özel Tasarım Okey Takımı";
                model.Resim = "/img/urunler/turk.png";
                model.Fiyat = "2500 TL";
                model.ProductDescription = "Türklerin kadim yurdu Ötüken’in ruhunu, modern tasarımın zarafetiyle buluşturun. Ötüken Serisi Özel Tasarım Okey Takımı, şanlı tarihimizin sembollerini ve Bozkurt figürünün asaletini oyun masanıza taşıyor. Sadece bir oyun seti değil, köklerimize olan bağlılığınızı simgeleyen bir koleksiyon parçası olan bu seri, estetik ve dayanıklılığı bir arada sunuyor.";
                model.Stock = 5;
            }
            else if (id == 6)
            {
                model.Id = 6;
                model.UrunAdi = "Türkiye Temalı Özel Tasarım Okey Takımı";
                model.Resim = "/img/urunler/turkiye.png";
                model.Fiyat = "2500 TL";
                model.ProductDescription = "Türkiye’mizin eşsiz ruhunu oyun masanıza taşıyın. Ay Yıldız Serisi Türkiye Temalı Özel Tasarım Okey Takımı, milli gururumuzu şık bir tasarımla buluşturuyor. Kırmızı-beyazın en güzel tonları ve ikonik Türkiye motifleriyle bezenmiş bu set, hem evinizdeki oyun saatlerine anlam katacak hem de sevdikleriniz için unutulmaz bir hediye olacaktır.";
                model.Stock = 9;
            }
            else if (id == 7)
            {
                model.Id = 7;
                model.UrunAdi = "Marvel Temalı Okey Takımı";
                model.Resim = "/img/urunler/marvel.png";
                model.Fiyat = "2500 TL";
                model.ProductDescription = "Oyun masanızda süper kahramanların gücüne yer açın! Marvel evreninin efsanevi karakterlerinden ilham alan bu özel tasarım okey takımı, sıradan bir oyun gecesini epik bir maceraya dönüştürüyor. Yenilmezler’in cesareti ve ikonik Marvel görselleriyle bezenmiş ıstakalar, hem stratejinizi hem de stilinizi masaya yansıtacak.";
                model.Stock = 7;
            }
            else if (id == 8)
            {
                model.Id = 8;
                model.UrunAdi = "Sahil Temalı Okey Takımı";
                model.Resim = "/img/urunler/sahil.png";
                model.Fiyat = "2500 TL";
                model.ProductDescription = "Deniz esintisini ve kumsalın huzurunu okey masanıza taşıyın. Sahil Serisi Özel Tasarım Okey Takımı, turkuaz suların dinginliğini ve altın sarısı kumların sıcaklığını yansıtan eşsiz görselleriyle tasarlanmıştır. Şehrin gürültüsünden uzaklaşıp kendinizi bir yaz akşamı sahil kenarında hissedeceğiniz bu set, oyun keyfinize ferahlık katıyor.";
                model.Stock = 8;
            }
            else if (id == 9)
            {
                model.Id = 9;
                model.UrunAdi = "Sünger Bob Temalı Okey Takımı";
                model.Resim = "/img/urunler/sungerbob.png";
                model.Fiyat = "2500 TL";
                model.ProductDescription = "Bikini Kasabası’nın en sevilen kahramanları şimdi okey masanıza konuk oluyor! Sünger Bob ve Arkadaşları Özel Tasarım Okey Takımı, çocukluğunuzun en eğlenceli anılarını ve okyanus altı dünyasının renkli enerjisini oyun gecelerinize taşıyor. Sünger Bob’un bitmek bilmeyen neşesi ve Patrick’in saflığıyla her el artık çok daha keyifli.";
                model.Stock = 5;
            }
            else if (id == 10)
            {
                model.Id = 10;
                model.UrunAdi = "Wednesday Okey Takımı";
                model.Resim = "/img/urunler/wednesday.png";
                model.Fiyat = "2500 TL";
                model.ProductDescription = "Gizemli ve karanlık tarzıyla öne çıkan bu özel tasarım okey takımı, Wednesday dizisinden ilham alınarak hazırlanmıştır. Wednesday karakterinin soğuk, mesafeli ve dikkat çekici estetiği bu üründe modern bir tasarımla buluşuyor.\r\n\r\nYüksek kaliteli malzeme kullanılarak üretilen bu okey ıstakası, uzun ömürlü kullanım sunarken şık görünümüyle de fark yaratır. Üzerindeki detaylı baskılar sayesinde hem oyun keyfinizi artırır hem de koleksiyonluk bir parça olarak öne çıkar.";
                model.Stock = 4;

            }
            else if (id == 11)
            {
                model.Id = 11;
                model.UrunAdi = "Yılbaşı Özel Tasarım Okey Takımı";
                model.Resim = "/img/urunler/yılbasi.png";
                model.Fiyat = "2500 TL";
                model.ProductDescription = "Yeni yılın neşesini ve enerjisini oyun keyfiyle birleştiren bu özel tasarım okey takımı, yılbaşı ruhunu sofranıza taşıyor. 🎁 Eğlenceli ve dikkat çekici detaylarıyla hem göze hitap eder hem de oyun anlarını daha keyifli hale getirir.\r\n\r\nYüksek kaliteli malzemeden üretilen bu okey ıstakası, dayanıklılığı ve uzun ömürlü yapısıyla öne çıkar. Üzerindeki canlı ve net baskılar sayesinde yılbaşı atmosferini her oyunda hissedersiniz.";
                model.Stock = 7;
            }
            else if (id == 12)
            {
                model.Id = 12;
                model.UrunAdi = "İsim Yazılı Özel Tasarım Okey Seti";
                model.Resim = "/img/urunler/isim-2.png";
                model.Fiyat = "2500 TL";
                model.ProductDescription = "Tamamen size özel olarak hazırlanan bu isim yazılı okey takımı, klasik oyun keyfini kişiselleştirilmiş bir tasarımla buluşturuyor. Üzerine istediğiniz isim, tarih veya kısa mesaj yazdırarak ürünü benzersiz hale getirebilirsiniz.\r\n\r\nYüksek kaliteli malzemeden üretilen bu okey ıstakası, dayanıklı yapısı ve uzun ömürlü baskısıyla hem estetik hem de kullanışlı bir deneyim sunar. Kişiye özel tasarımı sayesinde hem günlük kullanım hem de özel günler için ideal bir tercihtir.";
                model.Stock = 5;
            }
            else if (id == 13)
            {
                model.Id = 13;
                model.UrunAdi = "Şehir Temalı Okey Takımı(Denizli)";
                model.Resim = "/img/urunler/denizli.png";
                model.Fiyat = "2500 TL";
                model.ProductDescription = "Ege’nin incisi Denizli’nin doğal ve kültürel güzelliklerinden ilham alınarak tasarlanan bu özel okey takımı, şehrin ruhunu oyun keyfiyle buluşturuyor. Özellikle Pamukkale Travertenleri gibi eşsiz simgelerden esinlenen detaylar, ürüne estetik ve anlam katmaktadır.\r\n\r\nYüksek kaliteli malzemeden üretilen bu okey ıstakası, dayanıklılığı ve uzun ömürlü yapısıyla öne çıkar. Üzerindeki canlı ve net baskılar sayesinde hem görsel olarak şık bir görünüm sunar hem de keyifli oyun deneyimi sağlar.";
                model.Stock = 6;
            }
            else if (id == 14)
            {
                model.Id = 14;
                model.UrunAdi = "Kişiye Özel Okey Takımı";
                model.Resim = "/img/urunler/vadi.png";
                model.Fiyat = "2500 TL";
                model.ProductDescription = "Kendi tarzınızı yansıtan tamamen size özel bir okey takımıyla oyun keyfinizi bir üst seviyeye taşıyın. İster isim, ister fotoğraf, ister özel bir tasarım… Dilediğiniz detaylarla bu okey takımını tamamen kişiselleştirebilirsiniz.\r\n\r\nYüksek kaliteli malzeme kullanılarak üretilen bu okey ıstakası, hem dayanıklılığı hem de estetik görünümüyle dikkat çeker. Üzerindeki baskılar uzun ömürlü olup solma yapmaz, böylece yıllarca ilk günkü şıklığını korur..";
                model.Stock = 4;
            }
            else if (id == 15)
            {
                model.Id = 15;
                model.UrunAdi = "Şehir Temalı Okey Takımı(Van)";
                model.Resim = "/img/urunler/van.png";
                model.Fiyat = "2500 TL";
                model.ProductDescription = "Doğunun incisi Van’ın eşsiz doğası ve kültürel zenginliğinden ilham alınarak tasarlanan bu özel okey takımı, şehrin ruhunu oyun keyfiyle bir araya getiriyor. Özellikle Van Gölü ve Akdamar Adası gibi simgelerden esinlenen detaylar, ürüne estetik ve anlam katmaktadır.\r\n\r\nYüksek kaliteli malzemeden üretilen bu okey ıstakası, dayanıklılığı ve uzun ömürlü yapısıyla öne çıkar. Üzerindeki canlı ve net baskılar sayesinde hem şık bir görünüm sunar hem de keyifli bir oyun deneyimi sağlar.";
                model.Stock = 3;
            }


            return View(model);
        }
    }
}
