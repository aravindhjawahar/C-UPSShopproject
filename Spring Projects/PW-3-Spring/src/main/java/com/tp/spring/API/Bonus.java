/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.tp.spring.API;

import java.io.Serializable;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author Aravindh
 */
@Entity
@Table(name = "bonus")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Bonus.findAll", query = "SELECT b FROM Bonus b")
    , @NamedQuery(name = "Bonus.findBySsn", query = "SELECT b FROM Bonus b WHERE b.ssn = :ssn")
    , @NamedQuery(name = "Bonus.findByMultiplier", query = "SELECT b FROM Bonus b WHERE b.multiplier = :multiplier")})
public class Bonus implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @NotNull
    @Column(name = "ssn")
    private Integer ssn;
    // @Max(value=?)  @Min(value=?)//if you know range of your decimal fields consider using these annotations to enforce field validation
    @Column(name = "multiplier")
    private Double multiplier;

    public Bonus() {
    }

    public Bonus(Integer ssn) {
        this.ssn = ssn;
    }

    public Integer getSsn() {
        return ssn;
    }

    public void setSsn(Integer ssn) {
        this.ssn = ssn;
    }

    public Double getMultiplier() {
      return multiplier;    
    }

    public void setMultiplier(Double multiplier) {
        this.multiplier = multiplier;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (ssn != null ? ssn.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Bonus)) {
            return false;
        }
        Bonus other = (Bonus) object;
        if ((this.ssn == null && other.ssn != null) || (this.ssn != null && !this.ssn.equals(other.ssn))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "sp_practical3.domain.Bonus[ ssn=" + ssn + " ]";
    }
    
}
