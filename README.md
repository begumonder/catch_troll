#DAĞITIK VERSİYON KONTROL SİSTEMLERİ

Kullanıcıların dosyalarının son halini almalarına olanak tanır. Eğer sunuculardan herhangi biri çökerse diğer istemcilerde bulunan yazılım havuzundakileri sunucuya geri yükleyerek sistem kurtarılabilir.
#GIT
Git bir versiyon takip sistemidir. Projemizde yaptığımız değişiklikleri adım adım kayıt etmemize olanak tanır. Örneğin projemizde bizden veya çevresel faktörlerden gelen bir hasar ya da hatalı bir kod satırının sebep olduğu sorunlardan dolayı projemizin eski versiyonuna dönmemiz bizim için çok zor olacaktır, git ile bu sorunu kolayca aşabiliriz.	 
Eğer aynı projede birden fazla kişi çalışıyor ise git bize eş zamanlı olarak çalışma avantajı kazandırır. Git çok küçük ve kullanımı hızlıdır.

#GITHUB
Github proje yönetimini kolaylaştıran projenizin versiyonlarını depolayan bir web sitesidir. Github’ın ücretli ve ücretsiz olarak kullanabiliriz, eğer ücretsiz kullanıyor isek projemiz açık kaynak kodlu olacaktır. Github ile projenizi farklı şehir hatta ülkelerdeki yazılımcılar ile oluşturabilir onlara yetki verebilirsiniz. Github ile projede kimin hangi değişikliği ne zaman yaptığını ne kadar çalıştığını görebilirsiniz.
Bir diğer özeliği ise projenizde çalışmasa dahi başkaları sizin çalışmanızı alıp düzenleyip size projenizin o halini gönderebilir. Aynı şekilde sizde başkalarının projelerini alıp oradaki hataları bulup kendinizi geliştirebiliriz. Projenizde yeni bir kod ekleyecekseniz orijinal projenizi bozmadan *branch* oluşturarak deneyebilirsiniz.
Github’ın en önemli özelliği ise istenildiği zaman projenizin eski sürümünü indirip yeni sürüm ile karşılaştırmanıza olanak tanır.
#GİT İLE GITHUB’I BAĞLAMA VE KULLANIMI
Öncelikle git’i bu [adresten](https://git-scm.com "adresten") indirip kuruyoruz. Daha sonra dosyalarımızı github a göndermek için masa üstüne gelen git bash programına tıklıyoruz açılan konsola;

<code>Git config –-global user.email “mailadresiniz”</code>

yazıyoruz. Mailimizin eklendiğini onaylamak için;

<code>Git config --global user.email</code>

yazıyoruz. Eğer mailimiz yazıldıysa mailimizi eklemiş olduk. Bu kod sayesinde mailimizi global bir şekilde eklemiş olduk bir kereliğine eklemek istersek;

<code>Git config user.email “mailadresiniz”</code>

Kontrol için ise;

<code>Git config user.email </code>


Mailimizi ekledikten sonra eğer yeni bir proje açıyorsak komut penceresini açıp;
 
<code>git init</code>

yazıyoruz. Bu komut projemizin içinde git klasörü oluşturmamızı sağlıyor.
Eğer github’da zaten bir projemiz varsa veya başka birinin projesini çekmek istiyorsak;
![git clone](https://raw.githubusercontent.com/anet01/catch_troll/master/Resimler/git%20clone.jpg)

<code>git clone [clone url]</code> 

şeklinde klasöre dosyaları çekebiliriz.
Projede değişiklik yaptıktan sonra git hubdaki farklı ve değiştirilmiş dosyaları görebilmek için;

<code>git status</code> yazıyoruz.

Bu komuttan sonra eğer farklı dosyalarımız var ise;

 <code>git add [dosyaadı.uzantısı]</code> 

yazarak sadece o dosyayı veya 

<code>git add .</code> 

şeklinde tüm dosyaları git'e ekleyebiliriz.

Git’in takip ettiği ve üzerinde değişiklik yaptığımız dosyayı bildirmek için;

<code>git commit –m “yaptığımız değişiklik notu”</code>

![add-commit](https://raw.githubusercontent.com/anet01/catch_troll/master/Resimler/git%20add-commit.jpg)

 kodunu yazıyoruz. Dosyaları göndermek için;

<code>git push</code> yazıyoruz. 

Bu sayede dosyalarımızı göndermiş olduk.
Github’daki dosyaları eşitlemek için;

<code>git pull</code> kodu ile yapabiliriz.

Eğer local branch'i değiştirmeden sadece çalıştığımız dosyayı değiştirmek istersek;

<code>git fetch</code> yazmanız yeterli.

*Branch* ise projemizin orijinalini değiştirmeden o anki dosyalar ile istediğimiz değişikliği yapıp denemek için oluşturduğumuz dallardır. Bu özelliği kullanabilmek için önce github dan branch bölümünden istediğimiz bir isimle oluşturuyoruz daha sonra konsolda o branch’i oluşturup bağlanmak için;

<code>git checkout -b [branch ismi]</code> 
yazıyoruz.

Branchimizi github a göndermek için;

<code>git push origin [branch ismi]</code> 
yazarız.

Oluştuğunu kontrol etmek için;

<code>git branch</code> 

yazıyoruz ve branchimizin ismi orada göründüyse çalışıyor demektir. Master branch'e dönmek için ise;

<code>git checkout [branch adı]</code> 

ile seçiyoruz dosyaları push etmek için;

<code>git push –set—upstream origin [branch adı]</code>

 bu kod ile varsayılan push yerini değiştirmiş ve dosyalarımızı göndermiş olduk bunun içinde çalışmaya devam edeceksek;

![git push](https://raw.githubusercontent.com/anet01/catch_troll/master/Resimler/git%20push.png)

<code>git push </code> 

ile doğrudan yollayabiliriz, ama master *branch* imize geçeceksek yukarıdaki işlemleri tekrarlamamız gerekecek.
Projemizde çalışan diğer kişiler ile yaptıklarımız birleştireceksek;

<code>git merge</code> ile yapabiliriz.

Githubdan eski bir *commit*'i çekme getirmek için;

<code>git checkout [commit] [file]</code> ile getirebiliriz.
 
 Programınıza versiyon eklemek için;
 
 <code>git tag -a versiyon no -m "versiyon açıklaması"</code> kodunu kullanabiliriz.

#UPSTREAM İŞLEMİ/PULL REQUEST
Eğer *fork* ettiğimiz bir proje varsa ve biz fork ettikten sonra *fork* edilen orijinal projede değişiklik yapıldıysa o değişiklikleri almak için kullanılır.
Bu işlemi gerçekleştirmek için öncelikle;

<code>git remote add upstream [orjinal fork linki]</code> ile projemize upstream olarak ekliyoruz. Doğrulamak için;

<code>git remote -v</code> yazıyoruz eğer alttaki gibi bir ileti geldiyse *upstream*'i ekleyebilmişizdir.

![SS](https://raw.githubusercontent.com/anet01/catch_troll/master/Resimler/Ekran%20Al%C4%B1nt%C4%B1s%C4%B1.PNG)

<code>git checkout master</code>yazıp *master* *branch*'de olduğumuzdan emin olduktan sonra uzaktaki verileri çekmek için;

<code>git fetch upstream</code> yazıyoruz aldığımız dosyaları birleştirmek için ise;

<code>git merge upstream/master</code> yazıyoruz. Bu işlemlerden sonra *upstream*'i tamamlamış olduk.


#PROJEM
Projemin amacı 60 saniye içerisinde seçilen zorluk seviyesinde troll'e tıklayarak en yüksek puanı elde edebilmek.

 
HAZIRLAYAN

*Berkay BAHÇECİ*








