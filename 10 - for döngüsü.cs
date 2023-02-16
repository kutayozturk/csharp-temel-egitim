/*
For Döngüsü Genel Yazılışı

for(başlangıç değeri; bitiş değeri; artış miktarı)
{

//yapılacak işlemler;

}

---------------------------------------------------------
İç içe for döngüsü kullanımı

for(başlangıç değeri; bitiş değeri; artış miktarı)

{

   for(başlangıç değeri; bitiş değeri; artış miktarı)

    {

    //yapılacak işlemler;

    }

}

Örneğin
*/

for(int i=1; i<=10; i++)

{

   for(int j=1; j<=10; j++)

    {

    Console.WriteLine(i+"*"+j+"="+(i*j));

    }

}