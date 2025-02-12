/*
//definicja tablicy
int[] tab = new int[10];
int[] tab2 = new int[10];
//wypełnianie tablicy
for(int i=0;i< tab.Length;i++){
    tab[i]=i*i;
}
foreach(int item in tab){
    Console.WriteLine(item+" ");
}
void ShowTable(int[] tab){
    foreach(int item in tab){
        Console.WriteLine(item+" ");
    }
    Console.WriteLine();
}
//wyświetlanie tablicy
ShowTable(tab);
*/

//utworzyć tablice 10 elementową i wypełnić ją napisam


string[] napisy = new string[]{"Ala","ma","kota"};
for(int i=0;i<napisy.Length;i++){
    napisy[i]="";
}
ShowTable(napisy);
void ShowTable<T>(T[] napisy){
    foreach(T item in napisy){
        Console.Write(item+" ");
    }
    Console.WriteLine();
}

//napisac funkcje ktora zwaraca tablice
//liczb losowych o danym rozmiarze
Random random  = new Random();
random.Next(100);
int[] GeneralTab(int size){
    int[] result = new int[size];
    for(int i=0;i<size;i++){
        result[i] = random.Next(0,100);
    }
    return result;
}
ShowTable(GeneralTab(10));

//znajdz najwikszy element tablicy
//getMax(int[] tab) -> int
//getMin(int[] tab) -> int
//wyszukac amplitude tablicy (roznica miedzu najwiekszym i najmniejszym elementem)

int getMax(int[] tab){
    int max=0;
    for(int i=0;i<tab.Length;i++){
        if(max<tab[i]){
            max=tab[i];
        }
    }
    return max;
}
int getMin(int[] tab){
    int min=tab[0];
    for(int i=0;i<tab.Length;i++){
        if(min>tab[i]){
            min=tab[i];
        }
    }
    return min;
}
Console.WriteLine();
var dane=GeneralTab(10);
ShowTable(dane);
Console.WriteLine(getMax(dane));
Console.WriteLine(getMin(dane));
int roznica=getMax(dane)-getMin(dane);
Console.WriteLine("Różnica max i min: "+roznica);

int[] generDivBy(int size,int div){
    int[] result = new int[size];
    for(int i=0;i<size;i++){
        result[i]=random.Next(100)*div;
    }
    return result;
}
ShowTable(generDivBy(10,7));