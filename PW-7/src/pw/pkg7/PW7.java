/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pw.pkg7;

import com.entity.pkg.Cours;
import com.entity.pkg.Promotion;
import java.util.ArrayList;
import java.util.Collection;
import java.util.Date;
import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityTransaction;
import javax.persistence.Persistence;

/**
 *
 * @author Aravindh
 */
public class PW7 {

    EntityManagerFactory emf ; 
    EntityManager em ; 
    EntityTransaction tx ; 
    
    PW7()
    {
        this.emf = Persistence.createEntityManagerFactory("persistence"); 
        this.em = emf.createEntityManager(); 
        this.tx = em.getTransaction();
        this.tx.begin(); 
    }
    public void finish()
    {
        this.em.close(); 
        this.emf.close();
    }
    public void addCourses()
    {
        ArrayList<Cours> formation1 = new ArrayList<>();
        ArrayList<Cours> formation2 = new ArrayList<>();
        
        Cours cours = new Cours();
        Promotion promotion =  new Promotion();
        
        promotion.setIdPromotion(142);
        promotion.setLibelle("BE");
        
        cours.setLibelleCours("Software Engineering");
        cours.setIdCours(542);
        cours.setIdPromotion(promotion);
        cours.setDescription("course for CSE");
        cours.setDuree(4);
        cours.setDate(new Date());
       
        Cours cours1 = new Cours(promotion.getIdPromotion());
        
        cours1.setLibelleCours("Electronics Engineering");
        cours1.setIdCours(543);
        cours1.setIdPromotion(promotion);
        cours1.setDescription("course for ECE");
        cours1.setDuree(4);
        cours1.setDate(new Date());
        
        Promotion promotion1 = new Promotion();
        promotion1.setIdPromotion(143);
        promotion1.setLibelle("ME");
        Cours cour3 = new Cours();
        
        cour3.setLibelleCours("PLSI");
        cour3.setIdCours(543);
        cour3.setIdPromotion(promotion1);
        cour3.setDescription("Masters ECE");
        cour3.setDuree(2);
        cour3.setDate(new Date());
        formation1.add(cours); formation1.add(cours1);
        formation2.add(cour3);
        promotion.setCoursCollection(formation1);
        promotion1.setCoursCollection(formation2);
        
        this.em.persist(cour3); this.em.persist(promotion1); 
        this.em.persist(cours);this.em.persist(cours1);this.em.persist(promotion);
        this.tx.commit(); 
    }
    public void deletePromotion(int promotionID)
    {
        //this.tx.begin();
        Promotion pm = this.em.createNamedQuery("Promotion.findByIdPromotion", Promotion.class).setParameter("idPromotion",promotionID).getSingleResult();
        
        Collection<Cours> ls = pm.getCoursCollection();
        for(Cours cs :ls)
        {
            this.em.remove(cs);
        }
        this.em.remove(pm);
        this.tx.commit();
    }
    
    public static void main(String[] args) {
        
        PW7 p = new PW7();
        //p.addCourses();
        p.deletePromotion(1);
        p.finish();
    }
    
}