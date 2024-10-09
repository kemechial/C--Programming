
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

var sum = 0;

for(int i=0; i<101 ; ++i){
  sum+=i;
}

Console.WriteLine(sum);

while(sum<10000){
    sum++;
    Console.WriteLine(sum);
}
sum=0;

while(true){
    sum++;
    if(sum==3000)
       break;

    Console.WriteLine(sum);
}

for(int i=0; i<100; i++){
    if(i%2==0)
       continue;

       Console.WriteLine(i);
}
int j = 0;
do{
 j++;
 Console.WriteLine(2*j);

}while(j<10);

string test = "This is a sentence.";

foreach(char c in test){
    Console.WriteLine(c);
}