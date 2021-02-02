
package pw.pkg3;

import com.entity.pkg.Cours;
import com.entity.pkg.Promotion;
import java.util.ArrayList;
import java.util.Date;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityTransaction;
import javax.persistence.Persistence;

/**
 *
 * @author Aravindh
 */
public class Driver 
{
    
    public static void main(String[] args) 
    {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("persistence"); 
        EntityManager em = emf.createEntityManager(); 
        EntityTransaction tx = em.getTransaction(); 
        tx.begin(); 
        
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
        
        em.persist(cour3); em.persist(promotion1); 
        em.persist(cours);em.persist(cours1);em.persist(promotion);
        tx.commit(); 
        em.close(); 
        emf.close(); 
    }
}
