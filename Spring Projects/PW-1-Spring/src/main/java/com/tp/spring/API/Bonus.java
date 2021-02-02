/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.tp.spring.API;

/**
 *
 * @author Aravindh
 */
public class Bonus {
   private Integer ssn;
   private Double multiplier;

   public void setSsn(Integer ssn) {
      this.ssn = ssn;
   }
   public Integer getSsn() {
      return ssn;
   }
  
   public void setMultiplier(Double multiplier) {
      this.multiplier = multiplier;
   }
   public Double getMultiplier() {
      if(multiplier==null)return null; 
      return multiplier*100.0;
   }
}
