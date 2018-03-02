using Machine.Specifications;
using Domain.StaffUser;
using Domain.StaffUser.Registering;
using System;
using FluentValidation.Results;

namespace Domain.Specs.StaffUser.Registering.a_new_admin
{
    [Subject("Registering")]
    public class validating_a_user_that_is_already_registered
    {
        static RegisterNewAdminUser register;
        static RegisterNewAdminUserBusinessRulesValidator sut;
        static StaffUserIsRegistered staff_user_is_registered;
        static ValidationResult validation_results;
        Establish context = () => {
            register = new RegisterNewAdminUser
            {
                UserDetails = new Domain.StaffUser.BasicInfo
                {
                    StaffUserId = Guid.NewGuid(),
                    FullName = "blah",
                    DisplayName = "blah",
                    Email = "blah@blah.com"
                }
            };

            staff_user_is_registered = (id) => true;

            sut = new RegisterNewAdminUserBusinessRulesValidator(staff_user_is_registered);
        };

        Because of = () => validation_results = sut.Validate(register);

        It should_be_invalid = () => validation_results.ShouldBeInvalid();
        It should_have_one_invalidation = () => validation_results.ShouldHaveInvalidCountOf(1);
        It should_indicate_that_the_staff_user_id_is_invalid = () => validation_results.ShouldHaveInvalidProperty($"{nameof(register.UserDetails)}.{nameof(register.UserDetails.StaffUserId)}");
    }
}