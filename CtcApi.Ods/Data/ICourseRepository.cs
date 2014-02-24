//Copyright (C) 2011 Bellevue College and Peninsula College
//
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU Lesser General Public License as
//published by the Free Software Foundation, either version 3 of the
//License, or (at your option) any later version.
//
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU Lesser General Public License for more details.
//
//You should have received a copy of the GNU Lesser General Public
//License and GNU General Public License along with this program.
//If not, see <http://www.gnu.org/licenses/>.
using System.Collections.Generic;
using Ctc.Ods.Types;

namespace Ctc.Ods.Data
{
  /// <summary>
  /// Provides acccess to Course data from the ODS
  /// </summary>
  public interface ICourseRepository
  {
    /// <summary>
    /// Retrieves all <see cref="Course"/>s from the ODS
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    ///		<example>
    ///			<code type="cs">
    /// using (ICourseRepository repository = new OdsRepository())
    ///	{
    ///		IEnumerable&lt;Course&gt; courses = repository.GetCourses();
    /// }
    ///			</code>
    ///		</example>
    /// </remarks>
    IList<Course> GetCourses(IList<ISectionFacet> facetOptions = null);

    ///<summary>
    /// Retrieves the specified <see cref="Course"/>s from the ODS
    ///</summary>
    ///<param name="subject"></param>
    ///<param name="facetOptions"></param>
    ///<returns></returns>
    IList<Course> GetCourses(string subject, IList<ISectionFacet> facetOptions = null);

    /// <summary>
    /// Retrieves the specified <see cref="Course"/>s from the ODS
    /// </summary>
    /// <param name="subjects"></param>
    /// <param name="facetOptions"></param>
    /// <returns></returns>
    IList<Course> GetCourses(IList<string> subjects, IList<ISectionFacet> facetOptions = null);

    /// <summary>
    /// Retrieves the specified <see cref="Course"/>s from the ODS
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="facetOptions"></param>
    /// <returns>
    ///		<note type="note">
    ///		This method may return more than one <see cref="Course"/> record.
    ///		</note>
    /// </returns>
    /// <remarks>
    ///		<example>
    ///			<code type="cs">
    ///		using (ICourseRepository repository = new OdsRepository())
    ///		{
    ///			IList&lt;Course&gt; courses = repository.GetCourses(CourseID.FromString("ART 101"));
    ///		}
    ///			</code>
    ///		</example>
    /// </remarks>
    IList<Course> GetCourses(ICourseID courseId, IList<ISectionFacet> facetOptions = null);

    /// <summary>
    /// Retrieves specified course description from database
    /// </summary>
    /// <param name="courseID"></param>
    /// <param name="yrq"></param>
    /// <returns></returns>
    IList<CourseDescription> GetCourseDescription(ICourseID courseID, YearQuarter yrq = null);

    /// <summary>
    /// Returns an unfiltered list of all Course Subjects from the CoursePrefix table
    /// </summary>
    /// <remarks>
    /// This list is filtered to only include <see cref="Course"/> subjects which only have active courses
    /// in the current and/or future <see cref="YearQuarter"/>s.
    /// </remarks>
    /// <returns>List of CoursePrefix including Title and Subject</returns>
    IList<CoursePrefix> GetCourseSubjects();

    /// <summary>
    /// Returns filtered list of all Course Subjects by the first character in Title
    /// </summary>
    /// <param name="firstChar">The first character in Subject to search by</param>
    /// <remarks>
    /// This list is filtered to only include <see cref="Course"/> subjects which only have active courses
    /// in the current and/or future <see cref="YearQuarter"/>s.
    /// </remarks>
    /// <returns>Filtered list of CourseSubjects by the supplied char</returns>
    IList<CoursePrefix> GetCourseSubjects(char firstChar);

    ///	<summary>
    /// Returns a list of Course Subjects which have active <see cref="Section"/>s for
    /// the <see cref="YearQuarter"/> specified
    ///	</summary>
    ///	<param name="yrq"></param>
    ///<param name="facetOptions"></param>
    ///<returns></returns>
    IList<CoursePrefix> GetCourseSubjects(YearQuarter yrq, IList<ISectionFacet> facetOptions = null);
  }
}