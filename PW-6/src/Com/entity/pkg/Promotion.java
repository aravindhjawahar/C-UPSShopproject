/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Com.entity.pkg;

import java.io.Serializable;
import java.util.Collection;
import javax.persistence.Basic;
import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

/**
 *
 * @author Aravindh
 */
@Entity
@Table(name = "promotion")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Promotion.findAll", query = "SELECT p FROM Promotion p")
    , @NamedQuery(name = "Promotion.findByLibelle", query = "SELECT p FROM Promotion p WHERE p.libelle = :libelle")
    , @NamedQuery(name = "Promotion.findByIdPromotion", query = "SELECT p FROM Promotion p WHERE p.idPromotion = :idPromotion")})
public class Promotion implements Serializable {

    private static final long serialVersionUID = 1L;
    @Column(name = "LIBELLE")
    private String libelle;
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Basic(optional = false)
    @Column(name = "ID_PROMOTION")
    private Integer idPromotion;
    @OneToMany(cascade = CascadeType.ALL, mappedBy = "idPromotion")
    private Collection<Cours> coursCollection;

    public Promotion() {
    }

    public Promotion(Integer idPromotion) {
        this.idPromotion = idPromotion;
    }

    public String getLibelle() {
        return libelle;
    }

    public void setLibelle(String libelle) {
        this.libelle = libelle;
    }

    public Integer getIdPromotion() {
        return idPromotion;
    }

    public void setIdPromotion(Integer idPromotion) {
        this.idPromotion = idPromotion;
    }

    @XmlTransient
    public Collection<Cours> getCoursCollection() {
        return coursCollection;
    }

    public void setCoursCollection(Collection<Cours> coursCollection) {
        this.coursCollection = coursCollection;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (idPromotion != null ? idPromotion.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Promotion)) {
            return false;
        }
        Promotion other = (Promotion) object;
        if ((this.idPromotion == null && other.idPromotion != null) || (this.idPromotion != null && !this.idPromotion.equals(other.idPromotion))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "Com.entity.pkg.Promotion[ idPromotion=" + idPromotion + " ]";
    }
    
}
