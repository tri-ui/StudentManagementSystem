package Group9.Entity;

import java.io.Serializable;
import java.util.Set;

import javax.persistence.CascadeType;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name = "course")
public class Course implements Serializable {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String coursename;
    
    @OneToMany(mappedBy = "coursename", fetch = FetchType.LAZY,
            cascade = CascadeType.ALL)
    private Set<Record> record;
    
    @OneToMany(mappedBy = "coursename", fetch = FetchType.LAZY,
            cascade = CascadeType.ALL)
    private Set<Quiz> quiz;

	public Long getId() {
		return id;
	}

	public void setId(Long id) {
		this.id = id;
	}

	public String getCourse() {
		return coursename;
	}

	public void setCourse(String course) {
		this.coursename = course;
	}
    
    
}
