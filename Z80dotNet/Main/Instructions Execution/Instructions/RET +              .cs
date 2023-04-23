﻿
// AUTOGENERATED CODE
//
// Do not make changes directly to this (.cs) file.
// Change "RET +              .tt" instead.


namespace Konamiman.Z80dotNet
{
    public partial class Z80InstructionExecutor
    {
        /// <summary>
        /// The RET instruction.
        /// </summary>
        private byte RET()
        {
            FetchFinished(isRet: true);

			var sp = (ushort)Registers.SP;
            var newPC = NumberUtils.CreateShort(
                ProcessorAgent.ReadFromMemory(sp),
                ProcessorAgent.ReadFromMemory((ushort)(sp + 1)));
            Registers.PC = (ushort)newPC;

            Registers.SP += 2;

            return 10;
        }

        /// <summary>
        /// The RETI instruction.
        /// </summary>
        private byte RETI()
        {
            FetchFinished(isRet: true);

			var sp = (ushort)Registers.SP;
            var newPC = NumberUtils.CreateShort(
                ProcessorAgent.ReadFromMemory(sp),
                ProcessorAgent.ReadFromMemory((ushort)(sp + 1)));
            Registers.PC = (ushort)newPC;

            Registers.SP += 2;

            return 14;
        }

        /// <summary>
        /// The JP instruction.
        /// </summary>
        private byte JP_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();

			Registers.PC = newAddress;

            return 10;
        }

        /// <summary>
        /// The CALL instruction.
        /// </summary>
        private byte CALL_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();

			var valueToPush = (short)Registers.PC;
			var sp = (ushort)(Registers.SP - 1);
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetHighByte());
			sp--;
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetLowByte());
			Registers.SP = (short)sp;
			Registers.PC = newAddress;

            return 17;
        }

        /// <summary>
        /// The RET C instruction.
        /// </summary>
        private byte RET_C()
        {
            if(Registers.CF == 0) {
				FetchFinished(isRet: false);
                return 5;
			}

			FetchFinished(isRet: true);

			var sp = (ushort)Registers.SP;
            var newPC = NumberUtils.CreateShort(
                ProcessorAgent.ReadFromMemory(sp),
                ProcessorAgent.ReadFromMemory((ushort)(sp + 1)));
            Registers.PC = (ushort)newPC;

            Registers.SP += 2;

            return 11;
        }

        /// <summary>
        /// The JP C instruction.
        /// </summary>
        private byte JP_C_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();
            if(Registers.CF == 0)
                return 10;

			Registers.PC = newAddress;

            return 10;
        }

        /// <summary>
        /// The CALL C instruction.
        /// </summary>
        private byte CALL_C_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();
            if(Registers.CF == 0)
                return 10;

			var valueToPush = (short)Registers.PC;
			var sp = (ushort)(Registers.SP - 1);
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetHighByte());
			sp--;
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetLowByte());
			Registers.SP = (short)sp;
			Registers.PC = newAddress;

            return 17;
        }

        /// <summary>
        /// The RET NC instruction.
        /// </summary>
        private byte RET_NC()
        {
            if(Registers.CF == 1) {
				FetchFinished(isRet: false);
                return 5;
			}

			FetchFinished(isRet: true);

			var sp = (ushort)Registers.SP;
            var newPC = NumberUtils.CreateShort(
                ProcessorAgent.ReadFromMemory(sp),
                ProcessorAgent.ReadFromMemory((ushort)(sp + 1)));
            Registers.PC = (ushort)newPC;

            Registers.SP += 2;

            return 11;
        }

        /// <summary>
        /// The JP NC instruction.
        /// </summary>
        private byte JP_NC_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();
            if(Registers.CF == 1)
                return 10;

			Registers.PC = newAddress;

            return 10;
        }

        /// <summary>
        /// The CALL NC instruction.
        /// </summary>
        private byte CALL_NC_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();
            if(Registers.CF == 1)
                return 10;

			var valueToPush = (short)Registers.PC;
			var sp = (ushort)(Registers.SP - 1);
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetHighByte());
			sp--;
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetLowByte());
			Registers.SP = (short)sp;
			Registers.PC = newAddress;

            return 17;
        }

        /// <summary>
        /// The RET Z instruction.
        /// </summary>
        private byte RET_Z()
        {
            if(Registers.ZF == 0) {
				FetchFinished(isRet: false);
                return 5;
			}

			FetchFinished(isRet: true);

			var sp = (ushort)Registers.SP;
            var newPC = NumberUtils.CreateShort(
                ProcessorAgent.ReadFromMemory(sp),
                ProcessorAgent.ReadFromMemory((ushort)(sp + 1)));
            Registers.PC = (ushort)newPC;

            Registers.SP += 2;

            return 11;
        }

        /// <summary>
        /// The JP Z instruction.
        /// </summary>
        private byte JP_Z_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();
            if(Registers.ZF == 0)
                return 10;

			Registers.PC = newAddress;

            return 10;
        }

        /// <summary>
        /// The CALL Z instruction.
        /// </summary>
        private byte CALL_Z_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();
            if(Registers.ZF == 0)
                return 10;

			var valueToPush = (short)Registers.PC;
			var sp = (ushort)(Registers.SP - 1);
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetHighByte());
			sp--;
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetLowByte());
			Registers.SP = (short)sp;
			Registers.PC = newAddress;

            return 17;
        }

        /// <summary>
        /// The RET NZ instruction.
        /// </summary>
        private byte RET_NZ()
        {
            if(Registers.ZF == 1) {
				FetchFinished(isRet: false);
                return 5;
			}

			FetchFinished(isRet: true);

			var sp = (ushort)Registers.SP;
            var newPC = NumberUtils.CreateShort(
                ProcessorAgent.ReadFromMemory(sp),
                ProcessorAgent.ReadFromMemory((ushort)(sp + 1)));
            Registers.PC = (ushort)newPC;

            Registers.SP += 2;

            return 11;
        }

        /// <summary>
        /// The JP NZ instruction.
        /// </summary>
        private byte JP_NZ_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();
            if(Registers.ZF == 1)
                return 10;

			Registers.PC = newAddress;

            return 10;
        }

        /// <summary>
        /// The CALL NZ instruction.
        /// </summary>
        private byte CALL_NZ_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();
            if(Registers.ZF == 1)
                return 10;

			var valueToPush = (short)Registers.PC;
			var sp = (ushort)(Registers.SP - 1);
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetHighByte());
			sp--;
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetLowByte());
			Registers.SP = (short)sp;
			Registers.PC = newAddress;

            return 17;
        }

        /// <summary>
        /// The RET PE instruction.
        /// </summary>
        private byte RET_PE()
        {
            if(Registers.PF == 0) {
				FetchFinished(isRet: false);
                return 5;
			}

			FetchFinished(isRet: true);

			var sp = (ushort)Registers.SP;
            var newPC = NumberUtils.CreateShort(
                ProcessorAgent.ReadFromMemory(sp),
                ProcessorAgent.ReadFromMemory((ushort)(sp + 1)));
            Registers.PC = (ushort)newPC;

            Registers.SP += 2;

            return 11;
        }

        /// <summary>
        /// The JP PE instruction.
        /// </summary>
        private byte JP_PE_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();
            if(Registers.PF == 0)
                return 10;

			Registers.PC = newAddress;

            return 10;
        }

        /// <summary>
        /// The CALL PE instruction.
        /// </summary>
        private byte CALL_PE_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();
            if(Registers.PF == 0)
                return 10;

			var valueToPush = (short)Registers.PC;
			var sp = (ushort)(Registers.SP - 1);
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetHighByte());
			sp--;
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetLowByte());
			Registers.SP = (short)sp;
			Registers.PC = newAddress;

            return 17;
        }

        /// <summary>
        /// The RET PO instruction.
        /// </summary>
        private byte RET_PO()
        {
            if(Registers.PF == 1) {
				FetchFinished(isRet: false);
                return 5;
			}

			FetchFinished(isRet: true);

			var sp = (ushort)Registers.SP;
            var newPC = NumberUtils.CreateShort(
                ProcessorAgent.ReadFromMemory(sp),
                ProcessorAgent.ReadFromMemory((ushort)(sp + 1)));
            Registers.PC = (ushort)newPC;

            Registers.SP += 2;

            return 11;
        }

        /// <summary>
        /// The JP PO instruction.
        /// </summary>
        private byte JP_PO_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();
            if(Registers.PF == 1)
                return 10;

			Registers.PC = newAddress;

            return 10;
        }

        /// <summary>
        /// The CALL PO instruction.
        /// </summary>
        private byte CALL_PO_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();
            if(Registers.PF == 1)
                return 10;

			var valueToPush = (short)Registers.PC;
			var sp = (ushort)(Registers.SP - 1);
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetHighByte());
			sp--;
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetLowByte());
			Registers.SP = (short)sp;
			Registers.PC = newAddress;

            return 17;
        }

        /// <summary>
        /// The RET M instruction.
        /// </summary>
        private byte RET_M()
        {
            if(Registers.SF == 0) {
				FetchFinished(isRet: false);
                return 5;
			}

			FetchFinished(isRet: true);

			var sp = (ushort)Registers.SP;
            var newPC = NumberUtils.CreateShort(
                ProcessorAgent.ReadFromMemory(sp),
                ProcessorAgent.ReadFromMemory((ushort)(sp + 1)));
            Registers.PC = (ushort)newPC;

            Registers.SP += 2;

            return 11;
        }

        /// <summary>
        /// The JP M instruction.
        /// </summary>
        private byte JP_M_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();
            if(Registers.SF == 0)
                return 10;

			Registers.PC = newAddress;

            return 10;
        }

        /// <summary>
        /// The CALL M instruction.
        /// </summary>
        private byte CALL_M_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();
            if(Registers.SF == 0)
                return 10;

			var valueToPush = (short)Registers.PC;
			var sp = (ushort)(Registers.SP - 1);
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetHighByte());
			sp--;
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetLowByte());
			Registers.SP = (short)sp;
			Registers.PC = newAddress;

            return 17;
        }

        /// <summary>
        /// The RET P instruction.
        /// </summary>
        private byte RET_P()
        {
            if(Registers.SF == 1) {
				FetchFinished(isRet: false);
                return 5;
			}

			FetchFinished(isRet: true);

			var sp = (ushort)Registers.SP;
            var newPC = NumberUtils.CreateShort(
                ProcessorAgent.ReadFromMemory(sp),
                ProcessorAgent.ReadFromMemory((ushort)(sp + 1)));
            Registers.PC = (ushort)newPC;

            Registers.SP += 2;

            return 11;
        }

        /// <summary>
        /// The JP P instruction.
        /// </summary>
        private byte JP_P_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();
            if(Registers.SF == 1)
                return 10;

			Registers.PC = newAddress;

            return 10;
        }

        /// <summary>
        /// The CALL P instruction.
        /// </summary>
        private byte CALL_P_nn()
        {
			var newAddress = (ushort)FetchWord();

            FetchFinished();
            if(Registers.SF == 1)
                return 10;

			var valueToPush = (short)Registers.PC;
			var sp = (ushort)(Registers.SP - 1);
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetHighByte());
			sp--;
			ProcessorAgent.WriteToMemory(sp, valueToPush.GetLowByte());
			Registers.SP = (short)sp;
			Registers.PC = newAddress;

            return 17;
        }

    }
}