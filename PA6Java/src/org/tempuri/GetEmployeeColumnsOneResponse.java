/**
 * GetEmployeeColumnsOneResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetEmployeeColumnsOneResponse  implements java.io.Serializable {
    private org.tempuri.GetEmployeeColumnsOneResponseGetEmployeeColumnsOneResult getEmployeeColumnsOneResult;

    public GetEmployeeColumnsOneResponse() {
    }

    public GetEmployeeColumnsOneResponse(
           org.tempuri.GetEmployeeColumnsOneResponseGetEmployeeColumnsOneResult getEmployeeColumnsOneResult) {
           this.getEmployeeColumnsOneResult = getEmployeeColumnsOneResult;
    }


    /**
     * Gets the getEmployeeColumnsOneResult value for this GetEmployeeColumnsOneResponse.
     * 
     * @return getEmployeeColumnsOneResult
     */
    public org.tempuri.GetEmployeeColumnsOneResponseGetEmployeeColumnsOneResult getGetEmployeeColumnsOneResult() {
        return getEmployeeColumnsOneResult;
    }


    /**
     * Sets the getEmployeeColumnsOneResult value for this GetEmployeeColumnsOneResponse.
     * 
     * @param getEmployeeColumnsOneResult
     */
    public void setGetEmployeeColumnsOneResult(org.tempuri.GetEmployeeColumnsOneResponseGetEmployeeColumnsOneResult getEmployeeColumnsOneResult) {
        this.getEmployeeColumnsOneResult = getEmployeeColumnsOneResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetEmployeeColumnsOneResponse)) return false;
        GetEmployeeColumnsOneResponse other = (GetEmployeeColumnsOneResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getEmployeeColumnsOneResult==null && other.getGetEmployeeColumnsOneResult()==null) || 
             (this.getEmployeeColumnsOneResult!=null &&
              this.getEmployeeColumnsOneResult.equals(other.getGetEmployeeColumnsOneResult())));
        __equalsCalc = null;
        return _equals;
    }

    private boolean __hashCodeCalc = false;
    public synchronized int hashCode() {
        if (__hashCodeCalc) {
            return 0;
        }
        __hashCodeCalc = true;
        int _hashCode = 1;
        if (getGetEmployeeColumnsOneResult() != null) {
            _hashCode += getGetEmployeeColumnsOneResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(GetEmployeeColumnsOneResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetEmployeeColumnsOneResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getEmployeeColumnsOneResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetEmployeeColumnsOneResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>GetEmployeeColumnsOneResponse>GetEmployeeColumnsOneResult"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
    }

    /**
     * Return type metadata object
     */
    public static org.apache.axis.description.TypeDesc getTypeDesc() {
        return typeDesc;
    }

    /**
     * Get Custom Serializer
     */
    public static org.apache.axis.encoding.Serializer getSerializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanSerializer(
            _javaType, _xmlType, typeDesc);
    }

    /**
     * Get Custom Deserializer
     */
    public static org.apache.axis.encoding.Deserializer getDeserializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanDeserializer(
            _javaType, _xmlType, typeDesc);
    }

}
