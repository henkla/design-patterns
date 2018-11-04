/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package example;

import example.Components.Hawaii;
import example.Components.Ingemar;
import example.Decorators.ExtraCheeseTopping;
import example.Decorators.GarlicSauceTopping;
import example.Decorators.OnionTopping;

/**
 *
 * @author Henrik Larsson
 */
public class Example {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Hawaii hawaii = new Hawaii();
        System.out.println("Plain Hawaii: " + hawaii.getPrice());
        
        ExtraCheeseTopping extraCheese = new ExtraCheeseTopping(hawaii);
        OnionTopping onion = new OnionTopping(extraCheese);
        System.out.println("Plain Hawaii with extra cheese and onion: " + onion.getPrice());
        
        Ingemar ingemar = new Ingemar();
        extraCheese = new ExtraCheeseTopping(ingemar);
        onion = new OnionTopping(extraCheese);
        GarlicSauceTopping garlicSauce = new GarlicSauceTopping(onion);
        System.out.println("Plain Ingemar with extra cheese, garlic sauce and onion: " + garlicSauce.getPrice());
        
    }
    
}
