using SwamaanShaadi.DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DataLayer
{
    public class MemberDbInitializer : DropCreateDatabaseAlways<MembersContext>
    {
        protected override void Seed(MembersContext context)
        {
            context.Religions.AddRange(new List<Religion> {
                    new Religion { ReligionName = "Hindu",
                        Castes = new List<Caste> {
                            new Caste {CasteName = "Yadav" },
                            new Caste {CasteName = "Brahman" },
                            new Caste {CasteName = "Bhimihaar" },
                        }
                    },
                    new Religion { ReligionName = "Muslim", Castes = new List<Caste> { } }
            });

            context.HomeStates.AddRange( new List<HomeState> { 
                new HomeState {
                    StateName = "Bihar",
                    Districts = new List<District> {
                        new District { DistrictName = "Madhubani"},
                        new District { DistrictName = "Darbhanga" }
                    }
                }
            });

            context.EducationQualifications.AddRange(
                new List<Education> {
                    new Education { Degree = "Not formally educated"},
                    new Education { Degree = "10th Pass"},
                    new Education { Degree = "High School"},
                    new Education { Degree = "College education (BA, MA etc)"},
                    new Education { Degree = "Professional college education (Engineer, Doctor, CA etc)"}
                });

            context.Genders.AddRange(new List<Gender> {
                new Gender { Name = "Male" },
                new Gender { Name = "Female" }
            });

            context.AllProfileFor.AddRange(new List<ProfileFor> {
                new ProfileFor { Relation = "Self" },
                new ProfileFor { Relation = "Daughter" },
                new ProfileFor { Relation = "Son" },
                new ProfileFor { Relation = "Brother" },
                new ProfileFor { Relation = "Sister" },
                new ProfileFor { Relation = "Relative" },
                new ProfileFor { Relation = "Friend" },
            });

            context.MaritalStatuses.AddRange(new List<MaritalStatus> {
                new MaritalStatus { Status = "Single" },
                new MaritalStatus { Status = "Divorced" },
                new MaritalStatus { Status = "Widowed" }
            });

            context.EmploymentTypes.AddRange(new List<EmploymentType> {
                new EmploymentType { Type = "Salaried" },
                new EmploymentType { Type = "Not working" },
                new EmploymentType { Type = "Own business" }
            });

            context.AllAccountStatus.AddRange(new List<AccountStatus> {
                new AccountStatus { Status = "Active" },
                new AccountStatus { Status = "Inactive" }
            });

            base.Seed(context);
        }
    }
}
