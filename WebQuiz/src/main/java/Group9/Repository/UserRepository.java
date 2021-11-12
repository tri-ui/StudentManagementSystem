package Group9.Repository;

import org.springframework.data.repository.CrudRepository;

import Group9.Entity.User;

public interface UserRepository extends CrudRepository<User, Long> {

}
