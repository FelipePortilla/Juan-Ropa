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
public class VentaController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public VentaController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<VentaDto>>> Get()
    {
        var results = await _unitOfWork.Ventas.GetAllAsync();
        return _mapper.Map<List<VentaDto>>(results);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<VentaDto>> Get(int id)
    {
        var result = await _unitOfWork.Ventas.GetByIdAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        return _mapper.Map<VentaDto>(result);
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<VentaDto>> Post(VentaDto resultDto)
    {
        var result = _mapper.Map<Venta>(resultDto);
        _unitOfWork.Ventas.Add(result);
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
    public async Task<ActionResult<VentaDto>> Put(int id, [FromBody] VentaDto VentaDto)
    {
        var result = await _unitOfWork.Ventas.GetByIdAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        if (VentaDto.Id == 0)
        {
            VentaDto.Id = id;
        }
        if (VentaDto.Id != id)
        {
            return BadRequest();
        }
        // Update the properties of the existing entity with values from VentaDto
        _mapper.Map(VentaDto, result);
        // The context is already tracking result, so no need to attach it
        await _unitOfWork.SaveAsync();
        // Return the updated entity
        return _mapper.Map<VentaDto>(result);
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _unitOfWork.Ventas.GetByIdAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        _unitOfWork.Ventas.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}
