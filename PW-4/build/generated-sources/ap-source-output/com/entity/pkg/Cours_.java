package com.entity.pkg;

import com.entity.pkg.Etudiant;
import com.entity.pkg.Promotion;
import java.util.Date;
import javax.annotation.Generated;
import javax.persistence.metamodel.CollectionAttribute;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.5.2.v20140319-rNA", date="2020-12-13T20:28:15")
@StaticMetamodel(Cours.class)
public class Cours_ { 

    public static volatile SingularAttribute<Cours, Date> date;
    public static volatile SingularAttribute<Cours, Promotion> idPromotion;
    public static volatile SingularAttribute<Cours, Integer> idCours;
    public static volatile SingularAttribute<Cours, Integer> duree;
    public static volatile SingularAttribute<Cours, String> description;
    public static volatile CollectionAttribute<Cours, Etudiant> etudiantCollection;
    public static volatile SingularAttribute<Cours, String> libelleCours;

}