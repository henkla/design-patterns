/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package example.Decorators;

import example.Components.BasePizza;

/**
 *
 * @author Henrik Larsson
 */
public class GarlicSauceTopping extends BaseTopping {
    
    public GarlicSauceTopping(BasePizza pizzaToDecorate) {
        super(pizzaToDecorate);
        this.price = 8.90;
    }
}
