﻿using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Services
{
	public interface ICourseService
	{
		Task<Response<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto);
		Task<Response<NoContent>> DeleteAsync(string id);
		Task<Response<NoContent>> UpdateAsync(CourseUpdateDto courseUpdateDto);
		Task<Response<List<CourseDto>>> GetAllAsync();
		Task<Response<List<CourseDto>>> GetAllByUserId(string userId);
		Task<Response<CourseDto>> GetByIdAsync(string id);
		
	}
}