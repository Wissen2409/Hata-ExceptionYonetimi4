

Console.WriteLine("Lütfen değer giriniz");
try{

int deger = int.Parse(Console.ReadLine());
Console.WriteLine(deger);



}
catch(Exception ex){

// Catch bloğu içerisinde gelen tüm exceptionları, bir dosyaya yazalım


    DateTime dateTime = DateTime.Now;
    File.AppendAllText("/Users/emrahelis/Desktop/deneme.txt","\n"+dateTime.ToShortTimeString()+ "---"+ ex.Message);

}