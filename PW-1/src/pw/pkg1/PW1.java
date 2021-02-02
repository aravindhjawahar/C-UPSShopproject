/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pw.pkg1;

import Entity.pkg.Utilisateur;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityTransaction;
import javax.persistence.Persistence;

/**
 *
 * @author Aravindh
 */
public class PW1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws ParseException {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("Persistence"); 
        EntityManager em = emf.createEntityManager(); 
        EntityTransaction tx = em.getTransaction(); 
        tx.begin(); 

        Utilisateur u = new Utilisateur();
        u.setId(12);
        u.setDateInscription(new SimpleDateFormat( "yyyyMMdd" ).parse( "20100520" ));
        u.setEmail("aravindh@gmail.com");
        u.setMotDePasse("demo");
        u.setNom("Aravindh");
        
        em.persist(u);  
        tx.commit(); 
        em.close(); 
        emf.close(); 
    }
    
}
