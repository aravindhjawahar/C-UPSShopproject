/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Com.entity.pkg;

import java.io.Serializable;
import javax.persistence.Column;
import javax.persistence.EmbeddedId;
import javax.persistence.Entity;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author Aravindh
 */
@Entity
@Table(name = "cours_etudiant")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "CoursEtudiant.findAll", query = "SELECT c FROM CoursEtudiant c")
    , @NamedQuery(name = "CoursEtudiant.findByIdCours", query = "SELECT c FROM CoursEtudiant c WHERE c.coursEtudiantPK.idCours = :idCours")
    , @NamedQuery(name = "CoursEtudiant.findByIdEtudiant", query = "SELECT c FROM CoursEtudiant c WHERE c.coursEtudiantPK.idEtudiant = :idEtudiant")
    , @NamedQuery(name = "CoursEtudiant.findByNote", query = "SELECT c FROM CoursEtudiant c WHERE c.note = :note")})
public class CoursEtudiant implements Serializable {

    private static final long serialVersionUID = 1L;
    @EmbeddedId
    protected CoursEtudiantPK coursEtudiantPK;
    // @Max(value=?)  @Min(value=?)//if you know range of your decimal fields consider using these annotations to enforce field validation
    @Column(name = "NOTE")
    private Float note;
    @JoinColumn(name = "ID_ETUDIANT", referencedColumnName = "ID_ETUDIANT", insertable = false, updatable = false)
    @ManyToOne(optional = false)
    private Etudiant etudiant;
    @JoinColumn(name = "ID_COURS", referencedColumnName = "ID_COURS", insertable = false, updatable = false)
    @ManyToOne(optional = false)
    private Cours cours;

    public CoursEtudiant() {
    }

    public CoursEtudiant(CoursEtudiantPK coursEtudiantPK) {
        this.coursEtudiantPK = coursEtudiantPK;
    }

    public CoursEtudiant(int idCours, int idEtudiant) {
        this.coursEtudiantPK = new CoursEtudiantPK(idCours, idEtudiant);
    }

    public CoursEtudiantPK getCoursEtudiantPK() {
        return coursEtudiantPK;
    }

    public void setCoursEtudiantPK(CoursEtudiantPK coursEtudiantPK) {
        this.coursEtudiantPK = coursEtudiantPK;
    }

    public Float getNote() {
        return note;
    }

    public void setNote(Float note) {
        this.note = note;
    }

    public Etudiant getEtudiant() {
        return etudiant;
    }

    public void setEtudiant(Etudiant etudiant) {
        this.etudiant = etudiant;
    }

    public Cours getCours() {
        return cours;
    }

    public void setCours(Cours cours) {
        this.cours = cours;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (coursEtudiantPK != null ? coursEtudiantPK.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof CoursEtudiant)) {
            return false;
        }
        CoursEtudiant other = (CoursEtudiant) object;
        if ((this.coursEtudiantPK == null && other.coursEtudiantPK != null) || (this.coursEtudiantPK != null && !this.coursEtudiantPK.equals(other.coursEtudiantPK))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "Com.entity.pkg.CoursEtudiant[ coursEtudiantPK=" + coursEtudiantPK + " ]";
    }
    
}
