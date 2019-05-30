SELECT * FROM SecurityUser


SELECT p.uniqpolicy, l.uniqline, t.cdpolicylinetypecode AS line,
        c.descriptionof AS statusdescription, p.effectivedate,   
		p.expirationdate, p.policynumber, p.descriptionof AS policydescription  
FROM SecurityUserStructureCombinationJT jt
INNER JOIN structurecombination s  On  s.uniqstructure = jt.uniqstructure 
INNER JOIN policy p On p.uniqagency = s.uniqagency And p.uniqbranch = s.uniqbranch And p.uniqdepartment = s.uniqdepartment 
INNER JOIN line l ON l.uniqpolicy = p.uniqpolicy 
INNER JOIN cdpolicylinetype t ON t.uniqcdpolicylinetype = l.uniqcdpolicylinetype  
INNER JOIN cdlinestatus c ON c.uniqcdlinestatus = l.uniqcdlinestatus 


WHERE p.uniqentity = 93475 

SELECT COUNT(*) AS CountOf 
FROM SecurityUserStructureCombinationJT jt 
INNER JOIN structurecombination s  On  s.uniqstructure = jt.uniqstructure 
INNER JOIN policy p On p.uniqagency = s.uniqagency And p.uniqbranch = s.uniqbranch And p.uniqdepartment = s.uniqdepartment 
--WHERE p.uniqpolicy =  " & iPolicyID

SELECT * 
FROM SecurityUserStructureCombinationJT jt 
INNER JOIN structurecombination s  On  s.uniqstructure = jt.uniqstructure 
INNER JOIN policy p On p.uniqagency = s.uniqagency And p.uniqbranch = s.uniqbranch And p.uniqdepartment = s.uniqdepartment

-- modified CheckSecurityLogin query
SELECT COUNT(*) AS CountOf 
FROM SecurityUserStructureCombinationJT jt 
INNER JOIN structurecombination s  On  s.uniqstructure = jt.uniqstructure 
INNER JOIN policy p On p.uniqagency = s.uniqagency And p.uniqbranch = s.uniqbranch And p.uniqdepartment = s.uniqdepartment 
WHERE p.uniqpolicy =  205492

SELECT * 
FROM SecurityUserStructureCombinationJT jt 
INNER JOIN structurecombination s  On  s.uniqstructure = jt.uniqstructure 
INNER JOIN policy p On p.uniqagency = s.uniqagency And p.uniqbranch = s.uniqbranch And p.uniqdepartment = s.uniqdepartment 
WHERE p.uniqpolicy =  205492

--205492
--205501
--205517
--205527
--205555


SELECT COUNT(*) AS countof 
FROM securityuser u 
INNER JOIN securityuserstructurecombinationjt jt ON jt.uniqsecurityuser =  u.uniqsecurityuser 
INNER JOIN structurecombination s ON  s.uniqstructure = jt.uniqstructure 
INNER JOIN policy p ON p.uniqagency = s.uniqagency AND p.uniqbranch = s.uniqbranch AND p.uniqdepartment = s.uniqdepartment AND p.uniqpolicy = 
WHERE u.usercode = 'TestUser' --and p.uniqpolicy =  205492

SELECT *
FROM securityuser u 
INNER JOIN securityuserstructurecombinationjt jt ON jt.uniqsecurityuser =  u.uniqsecurityuser 
INNER JOIN structurecombination s ON  s.uniqstructure = jt.uniqstructure 
INNER JOIN policy p ON p.uniqagency = s.uniqagency AND p.uniqbranch = s.uniqbranch AND p.uniqdepartment = s.uniqdepartment 
WHERE u.usercode = 'TestUser'


--combined security policy check
-- 13 total rows TestUser
SELECT p.uniqpolicy, l.uniqline, t.cdpolicylinetypecode AS line, 
        c.descriptionof AS statusdescription, p.effectivedate,
	    p.expirationdate, p.policynumber, p.descriptionof AS policydescription 
FROM securityuser u 
INNER JOIN securityuserstructurecombinationjt jt ON jt.uniqsecurityuser =  u.uniqsecurityuser 
INNER JOIN structurecombination s ON  s.uniqstructure = jt.uniqstructure  
INNER JOIN policy p ON p.uniqagency = s.uniqagency AND p.uniqbranch = s.uniqbranch AND p.uniqdepartment = s.uniqdepartment 
INNER JOIN line l ON l.uniqpolicy = p.uniqpolicy  
INNER JOIN cdpolicylinetype t ON t.uniqcdpolicylinetype = l.uniqcdpolicylinetype  
INNER JOIN cdlinestatus c ON c.uniqcdlinestatus = l.uniqcdlinestatus  
WHERE p.uniqentity = 93458

--93458
--93475

-- 144 total rows EnterpriseAdmin
 SELECT p.uniqpolicy, l.uniqline, t.cdpolicylinetypecode AS line,      
    c.descriptionof AS statusdescription, p.effectivedate,     
	    p.expirationdate, p.policynumber, p.descriptionof AS policydescription 
		 FROM policy p  INNER JOIN line l ON l.uniqpolicy = p.uniqpolicy  
		 INNER JOIN cdpolicylinetype t ON t.uniqcdpolicylinetype = l.uniqcdpolicylinetype 
		  INNER JOIN cdlinestatus c ON c.uniqcdlinestatus = l.uniqcdlinestatus 
		   WHERE p.uniqentity = 93458


-- testuser query
SELECT p.uniqpolicy, l.uniqline, t.cdpolicylinetypecode As line, 
       c.descriptionof AS statusdescription, p.effectivedate,
       p.expirationdate, p.policynumber, p.descriptionof AS policydescription 
FROM securityuser u 
INNER Join securityuserstructurecombinationjt jt ON jt.uniqsecurityuser =  u.uniqsecurityuser 
INNER Join structurecombination s ON  s.uniqstructure = jt.uniqstructure 
INNER Join policy p ON p.uniqagency = s.uniqagency And p.uniqbranch = s.uniqbranch And p.uniqdepartment = s.uniqdepartment
INNER Join line l ON l.uniqpolicy = p.uniqpolicy  
INNER Join cdpolicylinetype t ON t.uniqcdpolicylinetype = l.uniqcdpolicylinetype 
INNER Join cdlinestatus c ON c.uniqcdlinestatus = l.uniqcdlinestatus 
WHERE p.uniqentity = 93458

SELECT p.uniqpolicy, l.uniqline, t.cdpolicylinetypecode AS line, 
       c.descriptionof AS statusdescription, p.effectivedate, 
       p.expirationdate, p.policynumber, p.descriptionof AS policydescription 
FROM policy p 
INNER JOIN line l ON l.uniqpolicy = p.uniqpolicy 
INNER JOIN cdpolicylinetype t ON t.uniqcdpolicylinetype = l.uniqcdpolicylinetype 
INNER JOIN cdlinestatus c ON c.uniqcdlinestatus = l.uniqcdlinestatus 
WHERE p.uniqentity = 93458



