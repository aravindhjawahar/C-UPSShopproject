package com.entity.pkg;

import com.entity.pkg.Cours;
import javax.annotation.Generated;
import javax.persistence.metamodel.CollectionAttribute;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.5.2.v20140319-rNA", date="2020-12-13T20:28:15")
@StaticMetamodel(Etudiant.class)
public class Etudiant_ { 

    public static volatile SingularAttribute<Etudiant, String> nom;
    public static volatile CollectionAttribute<Etudiant, Cours> coursCollection;
    public static volatile SingularAttribute<Etudiant, Integer> idEtudiant;

}