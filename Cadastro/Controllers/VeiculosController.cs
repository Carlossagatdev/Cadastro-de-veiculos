using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Controllers
{
    public class VeiculosController : Controller
    {
		private readonly Contexto _contexto;

		public VeiculosController(Contexto contexto)
		{
			_contexto = contexto;
		}

        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Veiculos.ToListAsync());
        }

		[HttpGet]
		public IActionResult CriarVeiculo()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CriarVeiculo(Veiculo veiculo)
		{
			if (ModelState.IsValid)
			{
				_contexto.Add(veiculo);
				await _contexto.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}

			else return View(veiculo);
		} 

		[HttpGet]
		public IActionResult AtualizarVeiculo(int? id)
		{
			if (id != null)
			{
				Veiculo veiculo = _contexto.Veiculos.Find(id);
				return View(veiculo);
			}
			else return NotFound();

		}

		[HttpPost]
		public async Task<IActionResult> AtualizarVeiculo(int? id, Veiculo veiculo)
		{
			if (id != null)
			{
				if (ModelState.IsValid)
				{
					_contexto.Update(veiculo);
					await _contexto.SaveChangesAsync();
					return RedirectToAction(nameof(Index));
				}
				else return View(veiculo);
			}

			else return NotFound();
		}

		[HttpGet]
		public IActionResult ExcluirVeiculo(int? id)
		{
			if (id != null)
			{
				Veiculo veiculo = _contexto.Veiculos.Find(id);
				return View(veiculo);
			}
			else return NotFound();

		}

		[HttpPost]
		public async Task<IActionResult> ExcluirVeiculo(int? id, Veiculo veiculo)
		{
			if (id != null)
			{
				_contexto.Remove(veiculo);
				await _contexto.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}

			else return NotFound();
		}
	}
}