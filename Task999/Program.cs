Task999.TestClass testClass=new Task999.TestClass();
Task999.TestClass testClass1=new Task999.TestClass();

testClass.A=5;
testClass1.A=6;
Console.WriteLine("Class1" + testClass.A);
Console.WriteLine("Class1" + testClass1.A);

int lenghNumber =0;
int position=0;
Console.WriteLine ("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

lenghNumber=GetLengh(number);

//Console.WriteLine ("4 position"+ getNumberbyPos(number,1,lenghNumber) );
Console.WriteLine ("revert number"+ GetRevertNumber(number) );
int GetRevertNumber(int num){
    int revNum=0;
    int lng=GetLengh(num);
    for(int i=1; i<= GetLengh(num); i++)
    {
revNum=revNum + getNumberbyPos(num, i,lng) * GetMult(i,lng);
    }
    return revNum;
}

int getNumberbyPos(int num, int pos, int leng){
    int cicle = leng-pos;
    for (int i =0; i< cicle;i++){
num=num/10;
    }
    for (int i=0; i<pos;i++){

    }
return num%10;

}

int GetLengh(int num){
int leng=0;
while(num>=1){
    num = num/10;
leng=leng+1;
}
    return leng;
} 

int GetMult(int pos, int len){
int mult=1;

for (int i=1; i<= pos-1 ;i++){
    mult=mult*10;
}
return mult;
}
