/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pw.pkg6;

import Com.entity.pkg.Cours;
import Com.entity.pkg.CoursEtudiant;
import Com.entity.pkg.CoursEtudiantPK;
import Com.entity.pkg.Etudiant;
import Com.entity.pkg.Promotion;
import java.util.ArrayList;
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
public class PW6 {

     EntityManagerFactory emf ; 
    EntityManager em ; 
    EntityTransaction tx ; 
    
    
    Cours cours = new Cours();
    Promotion promotion =  new Promotion();
    Cours cours1 ;
    Cours cour3 = new Cours();
     
     
    public PW6()
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
        etudiant1.setIdEtudiant(1);
        
        Etudiant etudiant2 = new Etudiant();
        etudiant2.setNom("MS Dhoni");
        etudiant2.setIdEtudiant(2);
        
        Etudiant etudiant3 = new Etudiant();
        etudiant3.setNom("S Raina");
        etudiant3.setIdEtudiant(3);
        
        //for etudiant class
        ArrayList<CoursEtudiant> etud1 = new ArrayList<>();
        ArrayList<CoursEtudiant> etud2 = new ArrayList<>();
        ArrayList<CoursEtudiant> etud3 = new ArrayList<>();
        
        //for cours class
        ArrayList<CoursEtudiant> coursC = new ArrayList<>();
        ArrayList<CoursEtudiant> coursC1 = new ArrayList<>();
        ArrayList<CoursEtudiant> coursC3 = new ArrayList<>();
        
        //for student==> 1
        CoursEtudiantPK pk1 = new CoursEtudiantPK(cours.getIdCours(),etudiant1.getIdEtudiant());
        CoursEtudiantPK pk2 = new CoursEtudiantPK(cours1.getIdCours(),etudiant1.getIdEtudiant());
        CoursEtudiant ce1 =  new CoursEtudiant(pk1);
        CoursEtudiant ce2 =  new CoursEtudiant(pk2);
        ce1.setEtudiant(etudiant1); ce1.setCours(cours); ce1.setNote(Float.MIN_VALUE);
        ce2.setEtudiant(etudiant1); ce2.setCours(cours1);ce2.setNote(Float.MIN_VALUE);
        coursC.add(ce1); coursC1.add(ce2); 
        etud1.add(ce1);  etud1.add(ce2);
        etudiant1.setCoursEtudiantCollection(etud1);
        cours.setCoursEtudiantCollection(coursC);
       
        //for student==>2
        CoursEtudiantPK pk3 = new CoursEtudiantPK(cours1.getIdCours(),etudiant2.getIdEtudiant());
        CoursEtudiant ce3 = new CoursEtudiant(pk3);
        ce3.setEtudiant(etudiant2); ce3.setCours(cours1); ce3.setNote(Float.MIN_NORMAL);
        coursC1.add(ce3);
        etud2.add(ce3);
        etudiant2.setCoursEtudiantCollection(etud2);
        cours1.setCoursEtudiantCollection(coursC1);
        
        //for student==>3
        CoursEtudiantPK pk4 = new CoursEtudiantPK(cours1.getIdCours(),etudiant3.getIdEtudiant());
        CoursEtudiantPK pk5 = new CoursEtudiantPK(cour3.getIdCours(),etudiant3.getIdEtudiant());
        CoursEtudiant ce4 =  new CoursEtudiant(pk4);
        CoursEtudiant ce5 =  new CoursEtudiant(pk5);
        ce4.setEtudiant(etudiant3); ce4.setCours(cours1); ce4.setNote(Float.MIN_VALUE);
        ce5.setEtudiant(etudiant3); ce5.setCours(cour3);ce5.setNote(Float.MIN_VALUE);
        coursC1.add(ce4); coursC3.add(ce5); 
        etud3.add(ce4);  etud3.add(ce5);
        etudiant3.setCoursEtudiantCollection(etud3);
        cour3.setCoursEtudiantCollection(coursC3);
        
        this.em.persist(cours1);this.em.persist(cours1);this.em.persist(cour3);
        this.em.persist(ce1);this.em.persist(ce2);this.em.persist(ce3);this.em.persist(ce4);this.em.persist(ce5);
        this.em.persist(etudiant1);this.em.persist(etudiant2);this.em.persist(etudiant3);
        
        this.tx.commit();
    }
    public void deleteCOurse(int courseID)
    {
        this.tx.begin();  
        for (Cours cs : this.em.createQuery("select c from Cours c where c.idCours = :courseID", Cours.class).setParameter("courseID",courseID).getResultList())
        {
            this.em.remove(cs);
        }
        this.tx.commit();
    }
    public static void main(String[] args) 
    {
        PW6 p = new PW6();
       p.formCourses();
       p.addStudentsToCourse();
        p.deleteCOurse(3);
        p.finish();
    }
    
}