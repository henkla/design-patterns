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
public abstract class BaseTopping extends BasePizza {
    
    protected BasePizza component;
    
    public BaseTopping(BasePizza component) {
        this.component = component;
    }
    
    @Override
    public double getPrice() {
        return this.component.getPrice() + this.price;
    }
}
