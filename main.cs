using System;

class MainClass {

static string CalculateBMI(int weight, int height){
    double BMI = (weight * 703)/(height * height);
    if(BMI < 18.5) return "Underweight";
    if(BMI >= 18.5 && BMI < 25) return "Normal";
    if(BMI >= 25 && BMI < 30) return "Overweight";
    if(BMI >=30) return "Obese";
    return "error";
}


  public static void Main (string[] args) {
    for(int i=1; i<=10;i++){
      Console.WriteLine ("Enter your weight: ");
      var w = Console.ReadLine();
      int weight = Convert.ToInt32(w);
      Console.WriteLine ("Enter your height: ");
      var h = Console.ReadLine();
      int height = Convert.ToInt32(h);
      Console.WriteLine(CalculateBMI(weight,height));
    }
    
  }
}