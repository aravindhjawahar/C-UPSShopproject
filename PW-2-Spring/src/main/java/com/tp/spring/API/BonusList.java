/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.tp.spring.API;

import java.util.List;

/**
 *
 * @author Aravindh
 */
public class BonusList {
    
    private List<Bonus> bonus;

    public void setBonus(List<Bonus> bonus) {
        this.bonus = bonus;
    }

    public List<Bonus> getBonus() {
             return bonus;
    }
      
}
