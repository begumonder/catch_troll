#GIT
Git bir versiyon takip sistemidir. Projemizde yaptığımız değişiklikleri adım adım kayıt etmemize olanak tanır. Örneğin projemizde bizden veya çevresel faktörlerden gelen bir hasar yada hatalı bir kod satırının sebep olduğu sorunlardan dolayı projemizin eski versiyonuna dönmemiz bizim için çok zor olacaktır, git ile bu sorunu kolayca aşabiliriz.	
Eğer aynı projede birden fazla kişi çalışıyor ise git bize eş zamanlı olarak çalışma avantajı kazandırır. Git çok küçük ve kullanımı hızlıdır.

#GITHUB
Github proje yönetimini kolaylaştıran projenizin versiyonlarını depolayan bir web sitesidir. Github’ın ücretli ve ücretsiz olarak kullanabiliriz, eğer ücretsiz kullanıyor isek projemiz açık kaynak kodlu olacaktır. Github ile projenizi farklı şehir hatta ülkelerdeki yazılımcılar ile oluşturabilir onlara yetki verebilirsiniz. Github ile projede kimin hangi değişikliği ne zaman yaptığını ne kadar çalıştığını görebilirsiniz.
Bir diğer özeliği ise projenizde çalışmasa dahi başkaları sizin çalışmanızı alıp düzenleyip size projenizin o halini gönderebilir. Aynı şekilde sizde başkalarının projelerini alıp oradaki hataları bulup kendinizi geliştirebiliriz. Projenizde yeni bir kod ekleyecekseniz orijinal projenizi bozmadan *branch* oluşturarak deneyebilirsiniz.
Github’ın en önemli özelliği ise istenildiği zaman projenizin eski sürümünü indirip yeni sürüm ile karşılaştırmanıza olanak tanır.
#GİT İLE GITHUB’I BAĞLAMA VE KULLANIMI
Öncelikle git’i bu [adresten](https://git-scm.com "adresten") indirip kuruyoruz. Daha sonra dosyalarımızı github a göndermek için masa üstüne gelen git bash programına tıklıyoruz açılan konsola ;

<code>Git config –-global user.email “mailadresiniz”</code>

yazıyoruz. Mailimizin eklendiğini onaylamak için;

<code>Git config --global user.email</code>

yazıyoruz. Eğer mailimiz yazıldıysa mailimizi eklemiş olduk. Bu kod sayesinde mailimizi global bir şekilde eklemiş olduk bir kereliğine eklemek istersek;

<code>Git config user.email “mailadresiniz”</code>

Konrol için ise;

<code>Git config user.email </code>


Mailimizi ekledikten sonra eğer yeni bir proje açıyorsak komut penceresini açıp;
 
<code>git init</code>

yazıyoruz. Bu komut projemizin içinde git klasörü oluşturmamızı sağlıyor.
Eğer github’da zaten bir projemiz varsa ;

<code>git clone [clone url]</code> 

şeklinde klasöre dosyaları çekebiliriz.
Projede değişiklik yaptıktan sonra git hubdaki farklılıkları görebilmek için 

<code>git status</code> yazıyoruz.

Bu komutdan sonra eğer farklı dosyalarımız var ise;

 <code>git add [dosyaadı.uzantısı]</code> 

yazarak sadece o dosyayı veya 

<code>git add .</code> 

şeklinde tüm dosyaları ekleyebiliriz.
Gitin takip ettiği ve üzerinde değişiklik yaptığımız dosyayı bildirmek için;

<code>git commit –m “yaptığımız değişiklik notu”</code>

 yazıyoruz. Dosyaları göndermek için;

<code>git push</code> yazıyoruz. 

Bu sayede dosyalarımızı göndermiş olduk.
Github daki dosyaları eşitlemek için;

<code>git pull</code> kodu ile yapabiliriz.

*Branch* ise projemizin orijinalini değiştirmeden o anki dosyalar ile istediğimiz değişikliği yapıp denemek için oluşturduğumuz dallardır. Bu özelliği kullanabilmek için önce github dan branch bölümünden istediğimiz bir isimle oluşturuyoruz daha sonra konsolda o branch’i oluşturup bağlanmak için;

<code>git branch [branch ismi]</code> 
githubda oluşturduğumuz branch ismini yazıyoruz. Oluştuğunu kontrol etmek için;

<code>git branch</code> 

yazıyoruz ve branchimizin ismi orada göründüyse çalışıyor demektir. O branchde çalışıp kayıt etmek için ise;

<code>git checkout [branch adı]</code> 

ile seçiyoruz dosyaları push etmek için;

<code>git push –set—upstream origin [branch adı]</code>

 bu kod ile varsayılan push yerini değiştirmiş ve dosyalarımızı göndermiş olduk bunun içinde çalışmaya devam edeceksek;

<code>git push </code> 

ile doğrudan yollayabiliriz, ama master *branch* imize geçeceksek yukarıdaki işlemleri tekrarlamamız gerekecek.
Projemizde çalışan diğer kişiler ile yaptıklarımız birleştireceksek;

<code>git merge</code> ile yapabiliriz.

Githubdan eski bir *commit*'i çekme getirmek için;

<code>git checkout [commit] [file]</code> ile getirebiliriz.
 
 Programınıza versiyon eklemek için;
 
 <code>git tag -a versiyon no -m "versiyon açıklaması"</code> kodunu kullanabiliriz.
 
 #PROJEMİN ÇALIŞMA MANTIĞI

Projemin amacı 60 saniye içerisinde seçilen zorluk seviyesinde en yüksek puanı elde edebilmek.

 
 









