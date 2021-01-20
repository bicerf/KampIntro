using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>  //ben mylistimde T ile çalıicam anlamına geliyor ama bu ne demek
    {
        T[] items;
        public MyList()  //constructor bloğu  ctor yapıp TAB TAB yap bloğu çalıştır
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;   //referans noyu geçici olarak saklıyor ve yeni eleman eklediğinde referans no değişmiyor newlediğin zaman
            items = new T[items.Length+1];  //eleman sayıyı 1 arttırıyor her defasında yeni bir item eklendiğinde
            for (int i = 0; i < tempArray.Length; i++) //bu kısım ise for döngüsü ile tempArraydeki inci değerini itemsdaki yeni arraydeki inci değere yazdırıyoruz ve son eleman kısım boş kalıyor
            {
                items[i] = tempArray[i]; //bu kısımda da items ı tempArray e eşitliyoruz i'.nci elemanını inci elemanına
            }

            items[items.Length - 1] = item; //son olarak bu kısımda da nihayet elemmanı ekliyıruz itemsın uzunluğunun sondan birinci indexindeki yere Add(T item) daki itemı koyuyyoruz!!1

 
         
        
        }
       

    }
}
