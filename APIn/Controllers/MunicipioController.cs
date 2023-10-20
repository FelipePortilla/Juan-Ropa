using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIn.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIn.Controllers;
public class MunicipioController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public MunicipioController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<MunicipioDto>>> Get()
    {
        var results = await _unitOfWork.Municipios.GetAllAsync();
        return _mapper.Map<List<MunicipioDto>>(results);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<MunicipioDto>> Get(int id)
    {
        var result = await _unitOfWork.Municipios.GetByIdAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        return _mapper.Map<MunicipioDto>(result);
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<MunicipioDto>> Post(MunicipioDto resultDto)
    {
        var result = _mapper.Map<Municipio>(resultDto);
        _unitOfWork.Municipios.Add(result);
        await _unitOfWork.SaveAsync();
        if (result == null)
        {
            return BadRequest();
        }
        resultDto.Id = result.Id;
        return CreatedAtAction(nameof(Post), new { id = resultDto.Id }, resultDto);
    }
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<MunicipioDto>> Put(int id, [FromBody] MunicipioDto MunicipioDto)
    {
        var result = await _unitOfWork.Municipios.GetByIdAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        if (MunicipioDto.Id == 0)
        {
            MunicipioDto.Id = id;
        }
        if (MunicipioDto.Id != id)
        {
            return BadRequest();
        }
        // Update the properties of the existing entity with values from MunicipioDto
        _mapper.Map(MunicipioDto, result);
        // The context is already tracking result, so no need to attach it
        await _unitOfWork.SaveAsync();
        // Return the updated entity
        return _mapper.Map<MunicipioDto>(result);
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _unitOfWork.Municipios.GetByIdAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        _unitOfWork.Municipios.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}
