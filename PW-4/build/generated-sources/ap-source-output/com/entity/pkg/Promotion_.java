package com.entity.pkg;

import com.entity.pkg.Cours;
import javax.annotation.Generated;
import javax.persistence.metamodel.CollectionAttribute;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.5.2.v20140319-rNA", date="2020-12-13T20:28:15")
@StaticMetamodel(Promotion.class)
public class Promotion_ { 

    public static volatile SingularAttribute<Promotion, Integer> idPromotion;
    public static volatile SingularAttribute<Promotion, String> libelle;
    public static volatile CollectionAttribute<Promotion, Cours> coursCollection;

}