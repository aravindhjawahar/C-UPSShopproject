/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pw.pkg8;

import com.entity.pkg.Cours;
import com.entity.pkg.Etudiant;
import com.entity.pkg.Promotion;
import java.util.ArrayList;
import java.util.Collection;
import java.util.Date;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityTransaction;
import javax.persistence.Persistence;

/**
 *
 * @author Aravindh
 */
public class PW8 {

    EntityManagerFactory emf ; 
    EntityManager em ; 
    EntityTransaction tx ; 
    
    Cours cours = new Cours();
    Promotion promotion =  new Promotion();
    Cours cours1 = new Cours();
    Promotion promotion1 = new Promotion();
    Cours cour3 = new Cours();
   
    PW8()
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
         
        promotion.setIdPromotion(142);
        promotion.setLibelle("BE");
        
        cours.setLibelleCours("Software Engineering");
        cours.setIdCours(542);
        cours.setIdPromotion(promotion);
        cours.setDescription("course for CSE");
        cours.setDuree(4);
        cours.setDate(new Date());
       
        cours1.setLibelleCours("Electronics Engineering");
        cours1.setIdPromotion(promotion);
        cours1.setIdCours(543);
        cours1.setIdPromotion(promotion);
        cours1.setDescription("course for ECE");
        cours1.setDuree(4);
        cours1.setDate(new Date());
        
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
        etudiant1.setIdEtudiant(1);
        
        Etudiant etudiant2 = new Etudiant();
        etudiant2.setNom("MS Dhoni");
        etudiant2.setIdEtudiant(2);
        
        Etudiant etudiant3 = new Etudiant();
        etudiant3.setNom("S Raina");
        etudiant3.setIdEtudiant(3);
        
        //for etudiant class
        ArrayList<Cours> etud1 = new ArrayList<>();
        ArrayList<Cours> etud2 = new ArrayList<>();
        ArrayList<Cours> etud3 = new ArrayList<>();
        
        //for cours class
        ArrayList<Etudiant> coursC = new ArrayList<>();
        ArrayList<Etudiant> coursC1 = new ArrayList<>();
        ArrayList<Etudiant> coursC3 = new ArrayList<>();
        
        //for student==> 1
        etud1.add(cours);etud1.add(cour3);
        coursC.add(etudiant1);coursC3.add(etudiant1);
        etudiant1.setCoursCollection(etud1);
        
        //for student==>2
         etud2.add(cours1);etud1.add(cour3);
         coursC1.add(etudiant2);coursC3.add(etudiant2);
         etudiant2.setCoursCollection(etud2);
         
        //for student==>3
        etud3.add(cours); etud3.add(cours1);
        coursC.add(etudiant3); coursC1.add(etudiant3);
        etudiant3.setCoursCollection(etud3);
        
        cours.setEtudiantCollection(coursC);
        cours1.setEtudiantCollection(coursC1);
        cour3.setEtudiantCollection(coursC3);
        
        this.em.persist(etudiant1);this.em.persist(etudiant2);this.em.persist(etudiant3);
        this.em.persist(cours);this.em.persist(cours1);this.em.persist(cour3);
        this.tx.commit();
    }
    public void deletePromotion(int courseID)
    {
        this.tx.begin();
        Cours courRemove =  this.em.createQuery("SELECT c FROM Cours c WHERE c.idCours = :idCours",Cours.class).setParameter("idCours",courseID).getSingleResult();
        Collection<Etudiant> courseStudentList = courRemove.getEtudiantCollection();
        for ( Etudiant e : courseStudentList )
        {
            for ( Cours searchCourse : e.getCoursCollection() )
            {
                if( searchCourse.getIdCours() == courseID )
                {
                    this.em.remove(searchCourse);
                }
            }
        }
        this.tx.commit();
    }
    
    public static void main(String[] args) {
        
        PW8 p = new PW8();
       p.addCourses();
       p.addStudentsToCourse();
        p.deletePromotion(2);
        p.finish();
    }
    
}