﻿
// AUTOGENERATED CODE
//
// Do not make changes directly to this (.cs) file.
// Change "LD rr,(aa)   .tt" instead.


namespace Konamiman.Z80dotNet
{
    public partial class Z80InstructionExecutor
    {
        /// <summary>
        /// The LD HL,(aa) instruction.
        /// </summary>
        byte LD_HL_aa()
        {
			var address = (ushort)FetchWord();
		    FetchFinished();

			Registers.HL = ReadShortFromMemory(address);

            return 16;
        }

        /// <summary>
        /// The LD DE,(aa) instruction.
        /// </summary>
        byte LD_DE_aa()
        {
			var address = (ushort)FetchWord();
		    FetchFinished();

			Registers.DE = ReadShortFromMemory(address);

            return 20;
        }

        /// <summary>
        /// The LD BC,(aa) instruction.
        /// </summary>
        byte LD_BC_aa()
        {
			var address = (ushort)FetchWord();
		    FetchFinished();

			Registers.BC = ReadShortFromMemory(address);

            return 20;
        }

        /// <summary>
        /// The LD SP,(aa) instruction.
        /// </summary>
        byte LD_SP_aa()
        {
			var address = (ushort)FetchWord();
		    FetchFinished();

			Registers.SP = ReadShortFromMemory(address);

            return 20;
        }

        /// <summary>
        /// The LD IX,(aa) instruction.
        /// </summary>
        byte LD_IX_aa()
        {
			var address = (ushort)FetchWord();
		    FetchFinished();

			Registers.IX = ReadShortFromMemory(address);

            return 20;
        }

        /// <summary>
        /// The LD IY,(aa) instruction.
        /// </summary>
        byte LD_IY_aa()
        {
			var address = (ushort)FetchWord();
		    FetchFinished();

			Registers.IY = ReadShortFromMemory(address);

            return 20;
        }

    }
}
