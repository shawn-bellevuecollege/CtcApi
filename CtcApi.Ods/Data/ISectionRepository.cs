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
  /// 
  /// </summary>
  public interface ISectionRepository
  {
    /// <summary>
    /// Retrieves an <see cref="IList{T}"/> of <see cref="Section"/>s
    /// </summary>
    /// <param name="facetOptions"></param>
    /// <returns></returns>
    IList<Section> GetSections(IList<ISectionFacet> facetOptions = null);

    /// <summary>
    /// Retrieves an <see cref="IList{T}"/> of <see cref="Section"/>s
    /// </summary>
    /// <param name="yrq"></param>
    /// <param name="facetOptions"></param>
    /// <returns></returns>
    IList<Section> GetSections(YearQuarter yrq, IList<ISectionFacet> facetOptions = null);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="yrq"></param>
    /// <param name="facetOptions"></param>
    /// <returns></returns>
    IList<Section> GetSections(ICourseID courseId, YearQuarter yrq = null, IList<ISectionFacet> facetOptions = null);

    /// <summary>
    /// Retrieve all Sections for a specified <see cref="Course.Subject"/>
    /// </summary>
    /// <param name="subject">The <see cref="Course"/> <see cref="Course.Subject"/> which you want to retrieve all Sections for.</param>
    /// <param name="yrq"><b>(OPTIONAL)</b> Filter results so they only include Sections in this YearQuarter</param>
    /// <param name="facetOptions"></param>
    /// <returns></returns>
    IList<Section> GetSections(string subject, YearQuarter yrq = null, IList<ISectionFacet> facetOptions = null);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="subjects"></param>
    /// <param name="yrq"></param>
    /// <param name="facetOptions"></param>
    /// <returns></returns>
    IList<Section> GetSections(IList<string> subjects, YearQuarter yrq = null, IList<ISectionFacet> facetOptions = null);

    /// <summary>
    /// Retrieve all Sections specified in the provided list of <see cref="SectionID"/>s
    /// </summary>
    /// <param name="sectionIds"></param>
    /// <param name="facetOptions"></param>
    /// <returns></returns>
    IList<Section> GetSections(IList<ISectionID> sectionIds, IList<ISectionFacet> facetOptions = null);

    /// <summary>
    /// Retrieve all Sections specified in the provided list of <see cref="CourseID"/>s
    /// </summary>
    /// <param name="courseIds"></param>
    /// <param name="yrq"></param>
    /// <param name="facetOptions"></param>
    /// <returns></returns>
    IList<Section> GetSections(IList<ICourseID> courseIds, YearQuarter yrq = null, IList<ISectionFacet> facetOptions = null);

    /// <summary>
    /// Retrieves the number of <see cref="Section"/>s the specified <see cref="Course"/> in the given <see cref="YearQuarter"/>
    /// </summary>
    /// <param name="courseID"></param>
    /// <param name="yrq"></param>
    /// <param name="facets"></param>
    /// <returns></returns>
    int SectionCountForCourse(ICourseID courseID, YearQuarter yrq, IList<ISectionFacet> facets = null);

    /// <summary>
    /// Retrieves the number of <see cref="Section"/>s the specified <see cref="Course"/> subject in the given <see cref="YearQuarter"/>
    /// </summary>
    /// <param name="subject"></param>
    /// <param name="yrq"></param>
    /// <param name="facets"></param>
    /// <returns></returns>
    int SectionCountForCourse(string subject, YearQuarter yrq, IList<ISectionFacet> facets = null);
  }
}