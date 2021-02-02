/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.entity.pkg;

import java.io.Serializable;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Embeddable;

/**
 *
 * @author Aravindh
 */
@Embeddable
public class CoursEtudiantPK implements Serializable {

    @Basic(optional = false)
    @Column(name = "ID_COURS")
    private int idCours;
    @Basic(optional = false)
    @Column(name = "ID_ETUDIANT")
    private int idEtudiant;

    public CoursEtudiantPK() {
    }

    public CoursEtudiantPK(int idCours, int idEtudiant) {
        this.idCours = idCours;
        this.idEtudiant = idEtudiant;
    }

    public int getIdCours() {
        return idCours;
    }

    public void setIdCours(int idCours) {
        this.idCours = idCours;
    }

    public int getIdEtudiant() {
        return idEtudiant;
    }

    public void setIdEtudiant(int idEtudiant) {
        this.idEtudiant = idEtudiant;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (int) idCours;
        hash += (int) idEtudiant;
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof CoursEtudiantPK)) {
            return false;
        }
        CoursEtudiantPK other = (CoursEtudiantPK) object;
        if (this.idCours != other.idCours) {
            return false;
        }
        if (this.idEtudiant != other.idEtudiant) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "com.entity.pkg.CoursEtudiantPK[ idCours=" + idCours + ", idEtudiant=" + idEtudiant + " ]";
    }
    
}
