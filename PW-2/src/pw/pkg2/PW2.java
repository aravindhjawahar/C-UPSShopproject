
package pw.pkg2;

import Entity.Unit.Utilisateur;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityTransaction;
import javax.persistence.Persistence;

/**
 *
 * @author Aravindh
 */
public class PW2
{
    EntityManagerFactory emf ; 
    EntityManager em ; 
    EntityTransaction tx;

    public PW2() {
         this.emf = Persistence.createEntityManagerFactory("persistence"); 
         this.em = emf.createEntityManager();
         this.tx = em.getTransaction();
         this.tx.begin();
    }
    public void addUsers() throws ParseException
    {
        Utilisateur u = new Utilisateur();
        u.setId(1);
        u.setDateInscription(new SimpleDateFormat( "yyyyMMdd" ).parse( "19990522" ));
        u.setEmail("mythu@gmail.com");
        u.setMotDePasse("mythu");
        u.setNom("Mythreyi");
        
        Utilisateur u2 = new Utilisateur();
        u2.setId(3);
        u2.setDateInscription(new SimpleDateFormat( "yyyyMMdd" ).parse( "20021207" ));
        u2.setEmail("barath@gmail.com");
        u2.setMotDePasse("barath");
        u2.setNom("Barath");
        
        Utilisateur u3 = new Utilisateur();
        u3.setId(4);
        u3.setDateInscription(new SimpleDateFormat( "yyyyMMdd" ).parse( "19960305" ));
        u3.setEmail("archana@gmail.com");
        u3.setMotDePasse("archana");
        u3.setNom("Archana");
        
        Utilisateur u4 = new Utilisateur();
        u4.setId(5);
        u4.setDateInscription(new SimpleDateFormat( "yyyyMMdd" ).parse( "19710706" ));
        u4.setEmail("jawahar@gmail.com");
        u4.setMotDePasse("jawahar");
        u4.setNom("Jawahar");
        
        Utilisateur u5 = new Utilisateur();
        u5.setId(6);
        u5.setDateInscription(new SimpleDateFormat( "yyyyMMdd" ).parse( "19730321" ));
        u5.setEmail("ananthi@gmail.com");
        u5.setMotDePasse("ananthi");
        u5.setNom("Ananthi");
        
        em.persist(u);  em.persist(u2); em.persist(u3); em.persist(u4); em.persist(u5);
        this.tx.commit(); 
    }
    // User with ID less than the given id inputted over the arguements of methods
    public List<Utilisateur> getUsers(int id)
    {
       return em.createQuery("SELECT u FROM Utilisateur u WHERE u.id < :id",Utilisateur.class).setParameter("id",id).getResultList();
    }
    public List<Utilisateur> getUsers()
    {
       return em.createQuery("SELECT u FROM Utilisateur u",Utilisateur.class).getResultList();
    }
    public Utilisateur getUser(int id)
    {
        return this.em.find(Utilisateur.class,id);
    }
    public Utilisateur getUser(String email)
    {
        return  this.em.createNamedQuery("Utilisateur.findByEmail",Utilisateur.class).setParameter("email", email).getSingleResult();
    }
    
    public void deleteUser(int id)
    {
        this.tx.begin();
        this.em.remove(this.em.find(Utilisateur.class,id));
        this.tx.commit();
    }
    public void updateUser(int id,String name)
    {
       Utilisateur u = this.em.createNamedQuery("Utilisateur.findById", Utilisateur.class).setParameter("id", id).getSingleResult();
       this.tx.begin();
       u.setNom(name);
       this.tx.commit();
       
    }
    public void finish()
    {
        this.em.close(); 
        this.emf.close();
    }
    public void printUsers(List<Utilisateur> users)
    {
        for (Utilisateur u : users)
        {
            System.out.println("ID : "+u.getId());
            System.out.println("Name : "+u.getNom());
            System.out.println("Password : "+u.getMotDePasse());
            System.out.println("EMail : "+u.getEmail());
            System.out.println("Date : "+u.getDateInscription());
        }
    }
    public void printUser(Utilisateur u)
    {
        System.out.println("ID : "+u.getId());
        System.out.println("Name : "+u.getNom());
        System.out.println("Password : "+u.getMotDePasse());
        System.out.println("EMail : "+u.getEmail());
        System.out.println("Date : "+u.getDateInscription());
    }
    public static void main(String[] args) throws ParseException 
    {
                
        PW2 p = new PW2();
        //create five users
        p.addUsers();
        
        //display all the users from the database using JPA
        p.printUsers(p.getUsers());
       
        //print user with id = 2
        p.printUser(p.getUser(2));
       
        //Delete user of ID = 3
        p.deleteUser(3);
       
        //update the user name with User ID
        String newName= "newname";
        p.updateUser(2,newName);
        
        //Get user with mail ID
        p.printUser( p.getUser("mythu@gmail.com") );
         
        //get list of user with id < 4
        p.printUsers(p.getUsers(4));
        
        p.finish();
        
    }
    
}
