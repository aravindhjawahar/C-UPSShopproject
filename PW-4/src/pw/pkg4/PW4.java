
package pw.pkg4;

import com.entity.pkg.Cours;
import com.entity.pkg.Etudiant;
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
public class PW4 
{

    EntityManagerFactory emf ; 
    EntityManager em ; 
    EntityTransaction tx ; 
    
    
    Cours cours = new Cours();
    Promotion promotion =  new Promotion();
    Cours cours1 ;
    Cours cour3 = new Cours();
     
     
    public PW4()
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
    public void formCourses()
    {
       
        ArrayList<Cours> formation1 = new ArrayList<>();
        ArrayList<Cours> formation2 = new ArrayList<>();
        
        promotion.setIdPromotion(142);
        promotion.setLibelle("BE");
        
        cours.setLibelleCours("Software Engineering");
        cours.setIdCours(542);
        cours.setIdPromotion(promotion);
        cours.setDescription("course for CSE");
        cours.setDuree(4);
        cours.setDate(new Date());
       
      
        cours1 = new Cours(promotion.getIdPromotion());
        
        cours1.setLibelleCours("Electronics Engineering");
        cours1.setIdCours(543);
        cours1.setIdPromotion(promotion);
        cours1.setDescription("course for ECE");
        cours1.setDuree(4);
        cours1.setDate(new Date());
        
        Promotion promotion1 = new Promotion();
        promotion1.setIdPromotion(143);
        promotion1.setLibelle("ME");
       
        
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
    public void addStudentsToCourse()
    {
        this.tx.begin();
        Etudiant etudiant1 = new Etudiant();
        etudiant1.setNom("Aravindh");
        
        Etudiant etudiant2 = new Etudiant();
        etudiant2.setNom("MS Dhoni");
        
        Etudiant etudiant3 = new Etudiant();
        etudiant3.setNom("S Raina");
        
        ArrayList<Cours> etud1 = new ArrayList<>();
        ArrayList<Cours> etud2 = new ArrayList<>();
        ArrayList<Cours> etud3 = new ArrayList<>();
        
        ArrayList<Etudiant> etudColl1 = new ArrayList<>();
        ArrayList<Etudiant> etudColl2 = new ArrayList<>();
        ArrayList<Etudiant> etudColl3 = new ArrayList<>();
        
        etudColl1.add(etudiant1);etudColl1.add(etudiant2);
        etudColl2.add(etudiant2);etudColl2.add(etudiant3);
        etudColl3.add(etudiant3);
        
        cours.setEtudiantCollection(etudColl1);
        cour3.setEtudiantCollection(etudColl3);
        cours1.setEtudiantCollection(etudColl2);
        
        etud1.add(cours); etud1.add(cours1);
        etud2.add(cour3); etud2.add(cours1);
        etud3.add(cour3);
        
        etudiant1.setCoursCollection(etud1);
        etudiant2.setCoursCollection(etud2);
        etudiant3.setCoursCollection(etud3);
        
        this.em.persist(etudiant1);this.em.persist(etudiant2);this.em.persist(etudiant3);
       this.tx.commit();
    }
    
    public static void main(String[] args) 
    {
        PW4 p = new PW4();
        p.formCourses();
        p.addStudentsToCourse();
        p.finish();
    }
    
}
