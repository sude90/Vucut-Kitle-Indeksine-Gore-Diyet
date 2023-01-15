using System;

namespace Diyet_Programı
{
    class Program
    {
        static void Main(string[] args)
        {
            double boy, kilo, v_k_i = 0;    //Boy, kilo ve vücut kitle indeksi değişken olarak tanımlanıyor.
            Console.Write("Boyunuzu 'm' Cinsinden Giriniz (Ör:1,50)  : ");
            boy = Convert.ToDouble(Console.ReadLine());    //Kullanıcıdan boyunun girilmesi isteniyor.
            Console.Write("Kilonuzu Giriniz : ");
            kilo = Convert.ToDouble(Console.ReadLine());   //Kullanıcıdan kilosunun girilmesi isteniyor.
            v_k_i = kilo / (boy * boy);    //Vücut kitle indeksi kullanıcının girmiş olduğu boy ve kiloya bağlı olarak hesaplanıyor.
            Console.WriteLine("****************************************************");
            Console.WriteLine("Vücut Kitle İndeksiniz : {0}", v_k_i);
            if (v_k_i < 18.5)
            {
                Console.WriteLine("Zayıf");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("Sağlığınızı korumak amacıyla sizin için bir liste hazırladık. Sağlıklı bir şekilde kilo almak için listemizi görmek istiyorsanız 'EVET', istemiyorsanız 'HAYIR' yazınız.");
                string girilen_deger = Console.ReadLine();
                if (girilen_deger == "HAYIR")
                {
                    Console.WriteLine("Çıkmak için 'ENTER' tuşuna basınız.");
                }
                else if (girilen_deger == "EVET")
                {
                    Console.Clear();
                    Console.WriteLine("Listemizi görmek istediğiniz için teşekkür ederiz. Sizin için hazırlanmış olan 1 haftalık program aşağıdaki gibidir :");
                    Console.WriteLine("1.GÜN");
                    Console.WriteLine("------------------KAHVALTI------------------");
                    Console.WriteLine("- Organik tereyağı ve kaşar ile hazırlanmış iki yumurtalı omlet.");
                    Console.WriteLine("- Üç dilim ay çekirdekli ekmek.");
                    Console.WriteLine("- Bir bardak taze portakal suyu.");
                    Console.WriteLine("- Reçel, bal, tereyağı gibi kahvaltılıklar.");
                    Console.WriteLine("- Yeşillikler.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Kahvaltının ardından ara öğün olarak bir bardak tam yağlı süt tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("-----------------ÖĞLE YEMEĞİ----------------");
                    Console.WriteLine("- Salça veya domates soslu bir porsiyon tavuk.");
                    Console.WriteLine("- Bir porsiyon pirinç pilavı.");
                    Console.WriteLine("- Zeytinyağlı bol yeşillikli salata.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Ara öğün olarak bir bardak ayran ve bir avuç kuruyemiş tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("----------------AKŞAM YEMEĞİ----------------");
                    Console.WriteLine("- Bir kase mercimek çorbası.");
                    Console.WriteLine("- Orta boy bol mazlemeli bir pizza.");
                    Console.WriteLine("- Bol zeytinyağlı herhangi bir salata.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Ara öğün olarak bir bardak boza ve bir avuç kabak çekirdeği tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("                                                                                             ");
                    Console.WriteLine("2.GÜN");
                    Console.WriteLine("------------------KAHVALTI------------------");
                    Console.WriteLine("- İki adet simit.");
                    Console.WriteLine("- Bolca peynir, zeytin, tereyağı, reçel, bal.");
                    Console.WriteLine("- İstenilen bir içecek.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Kahvaltının ardından ara öğün olarak bir bardak boza ve fındık tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("-----------------ÖĞLE YEMEĞİ----------------");
                    Console.WriteLine("- Bir kase domates çorbası.");
                    Console.WriteLine("- İster ızgara, ister yemek şeklinde bir porsiyon köfte.");
                    Console.WriteLine("- Bir porsiyon makarna.");
                    Console.WriteLine("- Çoban salatası.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Ara öğün olarak 5 kaşık tahin helva ve bir dilim ekmek tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("----------------AKŞAM YEMEĞİ----------------");
                    Console.WriteLine("- Bir kase yoğurt çorbası.");
                    Console.WriteLine("- Bir tabak bezelye yemeği.");
                    Console.WriteLine("- 3 dilim ekmek.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Ara öğün olarak bir bardak sahlep ve bir avuç badem tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("                                                                                             ");
                    Console.WriteLine("3.GÜN");
                    Console.WriteLine("------------------KAHVALTI------------------");
                    Console.WriteLine("- Bol kaşarla hazırlanmış bir adet sahanda yumurta.");
                    Console.WriteLine("- 1 adet simit.");
                    Console.WriteLine("- Bal, reçel ve zeytin.");
                    Console.WriteLine("- Bir adet domates.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Kahvaltının ardından ara öğün olarak bir avuç fındık tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("-----------------ÖĞLE YEMEĞİ----------------");
                    Console.WriteLine("- Bir porsiyon buğulanmış balık.");
                    Console.WriteLine("- Bir kase çoban salata.");
                    Console.WriteLine("- İki dilim ekmek.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Ara öğün olarak tahin pekmez ve iki dilim tam buğday ekmeği tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("----------------AKŞAM YEMEĞİ----------------");
                    Console.WriteLine("- Bir kase kıymalı mercimek yemeği.");
                    Console.WriteLine("- Bir adet kaşarlı pide.");
                    Console.WriteLine("- Bol zeytinyağı ve nar ekşili salata.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Ara öğün olarak bir bardak tam yağlı süt ve bir dilim kek tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("                                                                                             ");
                    Console.WriteLine("4.GÜN");
                    Console.WriteLine("------------------KAHVALTI------------------");
                    Console.WriteLine("- Dört dilim peynir.");
                    Console.WriteLine("- 1 adet domates.");
                    Console.WriteLine("- İki dilim ekmek.");
                    Console.WriteLine("- Bir adet domates.");
                    Console.WriteLine("- Reçel.");
                    Console.WriteLine("- Büyük bardakta taze sıkılmış portakal suyu.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Kahvaltının ardından ara öğün olarak üç adet lokum tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("-----------------ÖĞLE YEMEĞİ----------------");
                    Console.WriteLine("- Bir adet yumurtalı ve kıymalı pide.");
                    Console.WriteLine("- Bir kase cacık.");
                    Console.WriteLine("- Zeytinyağlı havuç.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Ara öğün olarak meyve tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("----------------AKŞAM YEMEĞİ----------------");
                    Console.WriteLine("- Üç adet kıymalı dolma.");
                    Console.WriteLine("- Bir kase cacık.");
                    Console.WriteLine("- Bir porsiyon makarna.");
                    Console.WriteLine("- Turşu.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Ara öğün olarak bir bardak tam yağlı süt tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("                                                                                             ");
                    Console.WriteLine("5.GÜN");
                    Console.WriteLine("------------------KAHVALTI------------------");
                    Console.WriteLine("- Bir adet tost.");
                    Console.WriteLine("- Bir kase tarhana çorbası.");
                    Console.WriteLine("- İki dilim ekmek.");
                    Console.WriteLine("- Bir adet domates.");
                    Console.WriteLine("- Reçel.");
                    Console.WriteLine("- Büyük bardakta taze sıkılmış portakal suyu.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Kahvaltının ardından ara öğün olarak iki ilim cevizli kek tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("-----------------ÖĞLE YEMEĞİ----------------");
                    Console.WriteLine("- Bir porsiyon menemen.");
                    Console.WriteLine("- Bir porsiyon zeytinyağlı fasulye.");
                    Console.WriteLine("- Zeytinyağlı havuç.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Ara öğün olarak bir avuç kuruyemiş tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("----------------AKŞAM YEMEĞİ----------------");
                    Console.WriteLine("- 6 adet mercimek köftesi.");
                    Console.WriteLine("- Bir porsiyon peynirli börek.");
                    Console.WriteLine("- Bir bardak ayran.");
                    Console.WriteLine("- Bol domates.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Ara öğün olarak meyve tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("                                                                                             ");
                    Console.WriteLine("6.GÜN");
                    Console.WriteLine("------------------KAHVALTI------------------");
                    Console.WriteLine("- İki adet sahanda kaşarlı yumurta.");
                    Console.WriteLine("- 3 dilim ekmek.");
                    Console.WriteLine("- İki dilim ekmek.");
                    Console.WriteLine("- 1 bardak portakal suyu.");
                    Console.WriteLine("- Reçel, tahin pekmez.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Kahvaltının ardından ara öğün olarak 1 bardak süt ile 3 adet lor kurabiyesi tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("-----------------ÖĞLE YEMEĞİ----------------");
                    Console.WriteLine("- Bir porsiyon tavuk ızgara.");
                    Console.WriteLine("- Bol zeytinyağı ve nar ekşisi ile hazırlanmış salata.");
                    Console.WriteLine("- Bir porsiyon patates püresi.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Ara öğün olarak bir bardak boza ve bir avuç kuruyemiş tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("----------------AKŞAM YEMEĞİ----------------");
                    Console.WriteLine("- Bir porsiyon kıymalı sebze çorbası.");
                    Console.WriteLine("- Bir porsiyon bonfile ızgara.");
                    Console.WriteLine("- Bol zeytinyağlı ve nar ekşili mevsim salatası.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Ara öğün olarak meyve tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("                                                                                             ");
                    Console.WriteLine("7.GÜN");
                    Console.WriteLine("------------------KAHVALTI------------------");
                    Console.WriteLine("- Bir adet simit.");
                    Console.WriteLine("- 1 yumurta.");
                    Console.WriteLine("- Domates - salatalık.");
                    Console.WriteLine("- Tahin pekmez.");
                    Console.WriteLine("- Zeytin.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Kahvaltının ardından ara öğün olarak boza ve 1 avuç badem tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("-----------------ÖĞLE YEMEĞİ----------------");
                    Console.WriteLine("- Bir kase domates çorbası.");
                    Console.WriteLine("- Fırında peynirli makarna.");
                    Console.WriteLine("- Bir kase cacık.");
                    Console.WriteLine("- Havuç salatası.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Ara öğün olarak bir avuç kuruyemiş tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("----------------AKŞAM YEMEĞİ----------------");
                    Console.WriteLine("- Bir porsiyon etli nohut.");
                    Console.WriteLine("- Bir porsiyon bol tereyağlı pirinç pilavı.");
                    Console.WriteLine("- Mevsim salatası.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Ara öğün olarak meyve tüketilebilir.");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("Bunların yanında vakit buldukça bol bol egzersiz yapılmalı ve su içilmeli.");
                }
            }
            else if (v_k_i >= 18.5 && v_k_i < 24.9)
            {
                Console.WriteLine("İdeal Kilo");
            }
            else if (v_k_i >= 25 && v_k_i < 29.9)
            {
                Console.WriteLine("Kilolu");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("Kilonuz çok fazla değil ancak ideal kilonun üstündesiniz. Sağlıklı bir şekilde ideal kiloya ulaşmanız amacı ile sizin için bir diyet listesi hazırladık. Bu programı görmek istiyorsanız 'EVET', istemiyorsanız 'HAYIR' yazınız.");
                string girilen_deger = Console.ReadLine();
                if (girilen_deger == "HAYIR")
                {
                    Console.WriteLine("Çıkmak için 'ENTER' tuşuna basınız.");
                }
                else if (girilen_deger == "EVET")
                {
                    Console.Clear();
                    Console.WriteLine("Listemizi görmek istediğiniz için teşekkür ederiz. Sizin için hazırlanmış olan 3 günlük diyet listesi aşağıdaki gibidir.");
                    Console.WriteLine("1.GÜN");
                    Console.WriteLine("------------------KAHVALTI-----------------");
                    Console.WriteLine("- 1 dilim tam buğday ekmeği.");
                    Console.WriteLine("- 1 haşlanmış yumurta.");
                    Console.WriteLine("- 1 bardak şekersiz yeşil çay.");
                    Console.WriteLine("===============================================================================================================================");
                    Console.WriteLine("----------------ÖĞLE YEMEĞİ----------------");
                    Console.WriteLine("- 1 porsiyon sebze yemeği.");
                    Console.WriteLine("- 1 kase yoğurt.");
                    Console.WriteLine("===============================================================================================================================");
                    Console.WriteLine("----------------AKŞAM YEMEĞİ---------------");
                    Console.WriteLine("- 1 kase sebze çorbası.");
                    Console.WriteLine("- Bol yeşillikli salata.");
                    Console.WriteLine("===============================================================================================================================");
                    Console.WriteLine("Ara öğünlerde çok aşırıya kaçmamak şartıyla atıştırmalık olarak meyve, kuruyemiş gibi türevi yiyecekler tüketebilirsiniz.");
                    Console.WriteLine("===============================================================================================================================");
                    Console.WriteLine("                                                                                                                               ");
                    Console.WriteLine("2.GÜN");
                    Console.WriteLine("-----------------KAHVALTI------------------");
                    Console.WriteLine("- 1 dilim tam buğday ekmeği.");
                    Console.WriteLine("- 2 dilim peynir.");
                    Console.WriteLine("- 1 bardak şekersiz yeşil çay.");
                    Console.WriteLine("===============================================================================================================================");
                    Console.WriteLine("----------------ÖĞLE YEMEĞİ----------------");
                    Console.WriteLine("- 100 gram kırmızı et.");
                    Console.WriteLine("- Bol yeşillikli salata.");
                    Console.WriteLine("===============================================================================================================================");
                    Console.WriteLine("----------------AKŞAM YEMEĞİ---------------");
                    Console.WriteLine("- 1 kase haşlanmış sebze.");
                    Console.WriteLine("===============================================================================================================================");
                    Console.WriteLine("Ara öğünlerde çok aşırıya kaçmamak şartıyla atıştırmalık olarak meyve, kuruyemiş gibi türevi yiyecekler tüketebilirsiniz.");
                    Console.WriteLine("===============================================================================================================================");
                    Console.WriteLine("                                                                                                                               ");
                    Console.WriteLine("3.GÜN");
                    Console.WriteLine("------------------KAHVALTI-----------------");
                    Console.WriteLine("- 1 adet haşlanmış yumurta.");
                    Console.WriteLine("- 1 kase yoğurt.");
                    Console.WriteLine("- 1 bardak şekersiz yeşil çay.");
                    Console.WriteLine("===============================================================================================================================");
                    Console.WriteLine("----------------ÖĞLE YEMEĞİ----------------");
                    Console.WriteLine("- 1 kase sebze çorbası.");
                    Console.WriteLine("- Bol yeşillikli salata.");
                    Console.WriteLine("===============================================================================================================================");
                    Console.WriteLine("----------------AKŞAM YEMEĞİ----------------");
                    Console.WriteLine("- 200 gram ızgara balık.");
                    Console.WriteLine("- Bol yeşillikli salata.");
                    Console.WriteLine("===============================================================================================================================");
                    Console.WriteLine("Ara öğünlerde çok aşırıya kaçmamak şartıyla atıştırmalık olarak meyve, kuruyemiş gibi türevi yiyecekler tüketebilirsiniz.");
                    Console.WriteLine("===============================================================================================================================");
                    Console.WriteLine("Bunların yanında akla geldikçe bol bol su tüketilmelidir.");

                }
            }
            else if (v_k_i >= 30 && v_k_i < 39.9)
            {
                Console.WriteLine("Obez");
                Console.WriteLine("                                                                                                                                                                                                      ");
                Console.WriteLine("Vücut kitle indeksiniz obez olduğunuzu gösteriyor ancak endişe etmeyin. Eski sağlığınıza erişmeniz amacıyla sizin için bir diyet listesi hazırladık. Bu listeyi görmek istiyorsanız 'EVET', istemiyorsanız 'HAYIR' yazınız.");
                string girilen_deger = Console.ReadLine();
                if (girilen_deger == "HAYIR")
                {
                    Console.WriteLine("Çıkmak için 'ENTER' tuşuna basınız.");
                }
                else if (girilen_deger == "EVET")
                {
                    Console.Clear();
                    Console.WriteLine("Sizin için hazırlamış olduğumuz listemizi görmek istediğiniz için teşekkür eder ve sağlıklı günler dileriz. Liste aşağıdaki gibidir : ");
                    Console.WriteLine("                                                                                                                                                                                                ");
                    Console.WriteLine("OBEZİTE DİYETİ");
                    Console.WriteLine("================KAHVALTI================");
                    Console.WriteLine("- İnce dilimlenmiş bir dilim kepek ekmeği.");
                    Console.WriteLine("- Kibrit kutusu hacminde tuzsuz lor peyniri. (Çok mecbur kalındığında olabildiğince tuzsuz ve az yağlı ak peynir de olabilir.)");
                    Console.WriteLine("- 1 adet haşlanmış yumurtanın beyazı.");
                    Console.WriteLine("- Söğüş domates.");
                    Console.WriteLine("- Salatalık.");
                    Console.WriteLine("- Şekersiz yeşil çay.");
                    Console.WriteLine("                                                                                                                                                                                                ");
                    Console.WriteLine("================ARA ÖĞÜN================");
                    Console.WriteLine("- 1 boyut meyve. (Muz, çilek, kivi, kavun gibi meyveler tercih edilmeyecek. Posalı meyveler tercih edilecek : Ekşi elma, portakal, en çok da yeşil erik gibi).");
                    Console.WriteLine("                                                                                                                                                                                                ");
                    Console.WriteLine("==============ÖĞLE YEMEĞİ===============");
                    Console.WriteLine("- 2 bardak su.");
                    Console.WriteLine("- Yeşil salata. (Yağsız ve tuzsuz. Bol elma sirkesi veya limon ile.)");
                    Console.WriteLine("- 8 kaşık sebze yemeği. (Salçasız, yağsız, tuzsuz, az baharatlı.)");
                    Console.WriteLine("- Yumurta büyüklüğünde 2 parça balık veya tavuk. (Yağsız, tuzsuz, haşlama veya ızgara.)");
                    Console.WriteLine("                                                                                                                                                                                                ");
                    Console.WriteLine("================ARA ÖĞÜN================");
                    Console.WriteLine("- 1 boyut meyve. (Muz, çilek, kivi, kavun gibi meyveler tercih edilmeyecek. Posalı meyveler tercih edilecek : Ekşi elma, portakal, en çok da yeşil erik gibi).");
                    Console.WriteLine("                                                                                                                                                                                                ");
                    Console.WriteLine("==============AKŞAM YEMEĞİ==============");
                    Console.WriteLine("- 2 bardak su.");
                    Console.WriteLine("- Yeşil salata. (Yağsız ve tuzsuz. Bol elma sirkesi veya limon ile.)");
                    Console.WriteLine("- 8 kaşık sebze yemeği. (Salçasız, yağsız, tuzsuz, az baharatlı.)");
                    Console.WriteLine("- Akşam yemeğinden 1 saat sonra yarım bardak (100 ML) light yoğurt.");
                    Console.WriteLine("                                                                                                                                                                                                ");
                    Console.WriteLine("================ARA ÖĞÜN================");
                    Console.WriteLine("- 1 boyut meyve. (Muz, çilek, kivi, kavun gibi meyveler tercih edilmeyecek. Posalı meyveler tercih edilecek : Ekşi elma, portakal, en çok da yeşil erik gibi).");
                    Console.WriteLine("************************************************************************************************************************************************************************************************");
                    Console.WriteLine("Biz bu listeyi hazırladık ancak siz bunun yanında uzman bir doktora da başvurmalısınız. Her ne olursa olsun bir doktor takibinde olmak her zaman en sağlıklı olandır. Sağlıklı günler dileriz.");
                }
            }
            else if (v_k_i >= 40)
            {
                Console.WriteLine("Morbid Obez");
                Console.WriteLine("Vücut kitle indeksi sonucuna bakıldığında morbid obez olduğunuz görülüyor. Bu hastalığın ne olduğunu ve nasıl tedavi edilebileceğini görmek istiyorsanız 'EVET', istemiyorsanız 'HAYIR' yazınız.");
                string girilen_deger = Console.ReadLine();
                if (girilen_deger == "HAYIR")
                {
                    Console.WriteLine("Çıkmak için 'ENTER' tuşuna basınız.");
                }
                else if (girilen_deger == "EVET")
                {
                    Console.Clear();
                    Console.WriteLine("Öncelikle yorumumuzu görmek istediğiniz için teşekkür ederiz. Morbid obez; ileri derecede -3.derece- bir obezite rahatsızlığıdır.Morbid obez tedavisi hastanın kendi başına tedavi uygulayabileceği bir hastalık değildir. Uzman bir doktorun gözetimi altındahastaya en uygun tedavi yöntemi seçilerek hasta eski sağlığına kavuşturulur.Ancak bizim de size verebileceğimiz bazı önerilerimiz vardır. ");
                    Console.WriteLine("                                                                                                                      ");
                    Console.WriteLine("MORBİD OBEZİTE TEDAVİLERİ NELERDİR ? ? ");
                    Console.WriteLine("- Diyet Tedavisi");
                    Console.WriteLine("- İlaç Tedavisi");
                    Console.WriteLine("- Tüp Mide Ameliyatı");
                    Console.WriteLine("- Mide Bypassı");
                    Console.WriteLine("- Mide Bandı gibi çeşitli tedavi türleri mevcuttur.");
                    Console.WriteLine("=======================================================================================================================");
                    Console.WriteLine("MORBİD OBEZİTE HASTALARI NE YEMEKTEN KAÇINMALIDIR ?");
                    Console.WriteLine("- Yüksek oranda şeker içeren yiyecekler.");
                    Console.WriteLine("- Yüksek oranda yağ içeren yiyecekler");
                    Console.WriteLine("- Cips, bisküvi, kraker gibi hazır gıdalar.");
                    Console.WriteLine("- Hamur işleri");
                    Console.WriteLine("- Beyaz un içeren tüm gıdalar.");
                    Console.WriteLine("- Beyaz ekmek.");
                    Console.WriteLine("- Alkol, gazlı içecekler, hazır meyve suları.");
                    Console.WriteLine("- Sucuk, salam, pastırma gibi yiyecekler.");
                    Console.WriteLine("- Ketçap, mayonez gibi hazır soslar.");
                    Console.WriteLine("- Kızartma, kavurma ile hazırlanan yiyecekler.");
                    Console.WriteLine("======================================================================================================================");
                    Console.WriteLine("MORBİD OBEZİTE HASTALARI NASIL BESLENEBİLİRLER ?");
                    Console.WriteLine("- İlk olarak bol bol egzersiz yapılmalıdır.");
                    Console.WriteLine("- Süt ve süt ürünleri.");
                    Console.WriteLine("- Meyve");
                    Console.WriteLine("- Sebze");
                    Console.WriteLine("- Doğru miktarda protein.");
                    Console.WriteLine("- Doğru miktarda karbonhidrat.");
                    Console.WriteLine("- Vitamin ve mineral içeren yiyecekler.");
                    Console.WriteLine("- Kepekli pirinç.");
                    Console.WriteLine("- Karabuğday.");
                    Console.WriteLine("- Tereyağı, kuyruk yağı gibi katı yağlar yerine fındık yağı, zeytinyağı gibi omega kaynağı olan sıvı yağlar tüketilmelidir.");
                    Console.WriteLine("                                                                                                                      ");
                    Console.WriteLine("    Biz bunlardan bahsettik ancak en başta da söylenildiği gibi bunların hepsi uzman bir doktor ve diyetisyen eşliğinde kişiyeuygun bir şekilde planlanmalı ve uygulanmalıdır. Geçmiş olsun dileklerimizi sunar, sağlıklı günler dileriz.");
                }
            }
            Console.ReadKey();
        }
    }
}
