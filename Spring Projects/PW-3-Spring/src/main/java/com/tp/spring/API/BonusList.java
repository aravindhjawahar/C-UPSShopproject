/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.tp.spring.API;

import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;
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
    	protected final Log logger = LogFactory.getLog(getClass());    
      public void bonusCalculation(List<Bonus> bonusList) {
      EntityManagerFactory entityManagerFactory = Persistence.createEntityManagerFactory("com.avel_springapp_war_0.0.1-SNAPSHOTPU");
       EntityManager entityManager = entityManagerFactory.createEntityManager();
        if (bonusList != null) {
            for (Bonus b : bonusList) {
                Double multiplierBonus = b.getMultiplier()==null ? null : b.getMultiplier()*100;
                b.setMultiplier(multiplierBonus);
                entityManager.getTransaction().begin();
                entityManager.merge(b);
                entityManager.getTransaction().commit();
            }
        entityManager.close();
        entityManagerFactory.close();}
    }
      
}
