using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bal Krishna Dhakal
 * Date: July 27, 2017
 * Description: This is the Abstract CardList Class
 * Version: 0.1 -Created Abstract CardList Class
 */

namespace COMP123_S2017_Lesson11B
{
    public abstract class CardList: List<Card>
    {
        // PRIVATE INSTANCE VARIABLES

        //PUBLIC PROPERTIES
        //CONSTRUCTORS
        public CardList()
        {
            this._initialize();

        }
        //PRIVATE METHODS
        protected abstract void _initialize()
        {

        }
        //PUBLIC METHODS
    }
}