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
using Ctc.Ods.Config;
using Ctc.Ods.Types;

namespace Ctc.Ods.Data
{
  /// <summary>
  /// 
  /// </summary>
  public interface IYearQuarterRepository
  {
    /// <summary>
    /// Gets the current <see cref="YearQuarter"/> for today's date
    /// </summary>
    /// <seealso cref="ApiSettings.YearQuarter"/>
    YearQuarter CurrentYearQuarter {get;}

    /// <summary>
    /// Gets the current registration <see cref="YearQuarter"/>for today's date
    /// </summary>
    /// <returns>The nearest <see cref="YearQuarter"/> that is currently open for registration.</returns>
    /// <seealso cref="GetRegistrationQuarters"/>
    /// <seealso cref="ApiSettings.YearQuarter"/>
    YearQuarter CurrentRegistrationQuarter {get;}

    /// <summary>
    /// Gets a list of <see cref="YearQuarter"/>s, starting with the current registration quarter
    /// </summary>
    /// <param name="count">Total number of <see cref="YearQuarter"/>s to return.</param>
    /// <returns>A list of <see cref="YearQuarter"/> objects, with the first being the current registration quarter.</returns>
    /// <seealso cref="CurrentRegistrationQuarter"/>
    /// <seealso cref="ApiSettings.YearQuarter"/>
    IList<YearQuarter> GetRegistrationQuarters(int count = 1);

    /// <summary>
    /// Gets a list of future <see cref="YearQuarter"/>s, starting with the current registration quarter.
    /// </summary>
    /// <param name="count">Total number of <see cref="YearQuarter"/>s to return (including the current quarter).</param>
    /// <returns>A list of <see cref="YearQuarter"/> objects, with the first being the current registration quarter.</returns>
    IList<YearQuarter> GetFutureQuarters(int count = 1);
  }
}