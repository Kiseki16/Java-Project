package Main;
import java.util.Scanner;
public class Main {

public static void main(String[]args){
	 	
        Scanner scan = new Scanner(System.in);
        
        System.out.println("Actual Consumption");
        int AC = scan.nextInt();
        System.out.println("Current Reading");
        int CR = scan.nextInt();
        System.out.println("Previous Reading");
        int PR = scan.nextInt();
        System.out.println("Total Bill");
        double TB = scan.nextDouble();
        
        
        double RPKH = TB/PR-CR;
        System.out.println("Owner");
        System.out.println("Rate per KWH = " + RPKH);
       
       
        System.out.println("Current Reading");
        int T1CR = scan.nextInt();
        System.out.println("Previous Reading");
        int T1PR = scan.nextInt();
       
        int T1AC = T1PR-T1CR;
        System.out.println("Tenant1");
        System.out.println("Actual Consumption = " + T1AC);

        System.out.println("Current Reading");
        int T2CR = scan.nextInt();
        System.out.println("Previous Reading");
        int T2PR = scan.nextInt();
       
        int T2AC = T2PR-T2CR;
        System.out.println("Tenant2");
        System.out.println("Actual Consumption = " + T2AC);
        
        double kwh = TB/AC;
        
        double D = TB-(kwh*(AC-T1AC+T2AC));
        double A = Math.round(D*100)/100;
        int B = (int) (TB -kwh*T1AC);
        int C = (int) (TB -kwh*T2AC);
        
        System.out.println("    ");
        System.out.println("KWH: "+ kwh);
        System.out.println("    ");
        System.out.println("Owner Total Bill: " + A );
        System.out.println("Tenant1 Total Bill: " + B );
        System.out.println("Tenant2 Total Bill: " + C );
    }
   
}
