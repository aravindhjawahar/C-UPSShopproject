/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.entity.pkg;

import java.io.Serializable;
import java.util.Date;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author Aravindh
 */
@Entity
@Table(name = "cours")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Cours.findAll", query = "SELECT c FROM Cours c")
    , @NamedQuery(name = "Cours.findByLibelleCours", query = "SELECT c FROM Cours c WHERE c.libelleCours = :libelleCours")
    , @NamedQuery(name = "Cours.findByIdCours", query = "SELECT c FROM Cours c WHERE c.idCours = :idCours")
    , @NamedQuery(name = "Cours.findByDate", query = "SELECT c FROM Cours c WHERE c.date = :date")
    , @NamedQuery(name = "Cours.findByDuree", query = "SELECT c FROM Cours c WHERE c.duree = :duree")
    , @NamedQuery(name = "Cours.findByDescription", query = "SELECT c FROM Cours c WHERE c.description = :description")})
public class Cours implements Serializable {

    private static final long serialVersionUID = 1L;
    @Column(name = "LIBELLE_COURS")
    private String libelleCours;
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Basic(optional = false)
    @Column(name = "ID_COURS")
    private Integer idCours;
    @Column(name = "DATE")
    @Temporal(TemporalType.DATE)
    private Date date;
    @Column(name = "DUREE")
    private Integer duree;
    @Column(name = "DESCRIPTION")
    private String description;
    @JoinColumn(name = "ID_PROMOTION", referencedColumnName = "ID_PROMOTION")
    @ManyToOne(optional = false)
    private Promotion idPromotion;

    public Cours() {
    }

    public Cours(Integer idCours) {
        this.idCours = idCours;
    }

    public String getLibelleCours() {
        return libelleCours;
    }

    public void setLibelleCours(String libelleCours) {
        this.libelleCours = libelleCours;
    }

    public Integer getIdCours() {
        return idCours;
    }

    public void setIdCours(Integer idCours) {
        this.idCours = idCours;
    }

    public Date getDate() {
        return date;
    }

    public void setDate(Date date) {
        this.date = date;
    }

    public Integer getDuree() {
        return duree;
    }

    public void setDuree(Integer duree) {
        this.duree = duree;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public Promotion getIdPromotion() {
        return idPromotion;
    }

    public void setIdPromotion(Promotion idPromotion) {
        this.idPromotion = idPromotion;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (idCours != null ? idCours.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Cours)) {
            return false;
        }
        Cours other = (Cours) object;
        if ((this.idCours == null && other.idCours != null) || (this.idCours != null && !this.idCours.equals(other.idCours))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "com.entity.pkg.Cours[ idCours=" + idCours + " ]";
    }
    
}
