/**
 * GetEmployeesWithMostAbscenseResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetEmployeesWithMostAbscenseResponse  implements java.io.Serializable {
    private org.tempuri.GetEmployeesWithMostAbscenseResponseGetEmployeesWithMostAbscenseResult getEmployeesWithMostAbscenseResult;

    public GetEmployeesWithMostAbscenseResponse() {
    }

    public GetEmployeesWithMostAbscenseResponse(
           org.tempuri.GetEmployeesWithMostAbscenseResponseGetEmployeesWithMostAbscenseResult getEmployeesWithMostAbscenseResult) {
           this.getEmployeesWithMostAbscenseResult = getEmployeesWithMostAbscenseResult;
    }


    /**
     * Gets the getEmployeesWithMostAbscenseResult value for this GetEmployeesWithMostAbscenseResponse.
     * 
     * @return getEmployeesWithMostAbscenseResult
     */
    public org.tempuri.GetEmployeesWithMostAbscenseResponseGetEmployeesWithMostAbscenseResult getGetEmployeesWithMostAbscenseResult() {
        return getEmployeesWithMostAbscenseResult;
    }


    /**
     * Sets the getEmployeesWithMostAbscenseResult value for this GetEmployeesWithMostAbscenseResponse.
     * 
     * @param getEmployeesWithMostAbscenseResult
     */
    public void setGetEmployeesWithMostAbscenseResult(org.tempuri.GetEmployeesWithMostAbscenseResponseGetEmployeesWithMostAbscenseResult getEmployeesWithMostAbscenseResult) {
        this.getEmployeesWithMostAbscenseResult = getEmployeesWithMostAbscenseResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetEmployeesWithMostAbscenseResponse)) return false;
        GetEmployeesWithMostAbscenseResponse other = (GetEmployeesWithMostAbscenseResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getEmployeesWithMostAbscenseResult==null && other.getGetEmployeesWithMostAbscenseResult()==null) || 
             (this.getEmployeesWithMostAbscenseResult!=null &&
              this.getEmployeesWithMostAbscenseResult.equals(other.getGetEmployeesWithMostAbscenseResult())));
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
        if (getGetEmployeesWithMostAbscenseResult() != null) {
            _hashCode += getGetEmployeesWithMostAbscenseResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(GetEmployeesWithMostAbscenseResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetEmployeesWithMostAbscenseResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getEmployeesWithMostAbscenseResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetEmployeesWithMostAbscenseResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>GetEmployeesWithMostAbscenseResponse>GetEmployeesWithMostAbscenseResult"));
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
